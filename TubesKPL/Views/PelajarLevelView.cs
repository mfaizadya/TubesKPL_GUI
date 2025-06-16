using AuthAPI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;
using TubesKPL.Models;

namespace TubesKPL
{
    public partial class PelajarLevelView : Form
    {
        // Properti dan field utama
        private readonly Level level;                       // Level yang sedang dikerjakan
        private readonly LoginResponse loginData;           // Data login pelajar
        private int currentSoalIndex = 0;                   // Indeks soal yang sedang ditampilkan
        private readonly List<JawabanPengguna> jawabanUser = new(); // Menyimpan jawaban pelajar

        // Konstruktor utama
        public PelajarLevelView(Level level, LoginResponse loginData)
        {
            InitializeComponent();
            this.level = level;
            this.loginData = loginData;

            labelLevel.Text = $"Level {level.IdLevel}!";
            LoadSoal();
        }

        // Fungsi untuk menampilkan soal sesuai indeks
        private void LoadSoal()
        {
            if (level.SoalList != null && level.SoalList.Count > 0 && currentSoalIndex < level.SoalList.Count)
            {
                var soal = level.SoalList[currentSoalIndex];
                labelSoal.Text = soal.Pertanyaan;

                // Jika soal berupa isian (jenis = 0)
                if (soal.Jenis == 0)
                {
                    txtJawaban.Visible = true;
                    txtJawaban.Text = "";
                    listBoxOpsi.Visible = false;
                }
                // Jika soal pilihan ganda
                else
                {
                    txtJawaban.Visible = false;
                    listBoxOpsi.Visible = true;
                    listBoxOpsi.Items.Clear();

                    foreach (var opsi in soal.Opsi)
                    {
                        listBoxOpsi.Items.Add(opsi);
                    }

                    listBoxOpsi.ClearSelected();
                }

                // Tampilkan tombol selesai jika soal terakhir
                buttonSelesai.Visible = currentSoalIndex == level.SoalList.Count - 1;
                buttonNext.Visible = !buttonSelesai.Visible;
            }
        }

        // Menyimpan jawaban pengguna untuk soal yang sedang aktif
        private void SimpanJawabanSaatIni()
        {
            var soal = level.SoalList[currentSoalIndex];
            string jawaban = "";
            double skor = 0;

            if (soal.Jenis == 0)
            {
                jawaban = txtJawaban.Text.Trim();
            }
            else if (soal.Jenis != 0 && listBoxOpsi.SelectedItem != null)
            {
                jawaban = listBoxOpsi.SelectedItem.ToString();
            }

            // Perbarui jika sudah ada jawaban untuk soal ini
            var existing = jawabanUser.FirstOrDefault(j => j.IdSoal == soal.Id);

            if (existing != null)
            {
                existing.Jawaban = jawaban;
            }
            else
            {
                if (jawaban == soal.Jawaban)
                {
                    skor++;
                }

                jawabanUser.Add(new JawabanPengguna
                {
                    IdSoal = soal.Id,
                    Jawaban = jawaban,
                    Skor = skor
                });
            }
        }

        // Event tombol "Next" ditekan
        private void button1_Click(object sender, EventArgs e)
        {
            SimpanJawabanSaatIni();

            if (currentSoalIndex + 1 < level.SoalList.Count)
            {
                currentSoalIndex++;
                LoadSoal();
            }
            else
            {
                MessageBox.Show("Soal terakhir telah selesai. Silakan klik 'Finish'.");
            }
        }

        // Event tombol "Finish" ditekan
        private void button1_Click_1(object sender, EventArgs e)
        {
            SimpanJawabanSaatIni();

            string outputPath = "data_attempt.json";
            List<Attempt> listAttempts = new();

            // Ambil data attempt sebelumnya jika ada
            if (File.Exists(outputPath))
            {
                string existingJson = File.ReadAllText(outputPath);
                listAttempts = JsonSerializer.Deserialize<List<Attempt>>(existingJson) ?? new List<Attempt>();
            }

            // Hitung skor total dan simpan attempt
            double skor = HitungNilai(jawabanUser);
            var dataAttempt = new Attempt(
                listAttempts.Count,
                loginData.username,
                level.NamaLevel,
                skor,
                DateTime.Now,
                jawabanUser
            );

            listAttempts.Add(dataAttempt);

            string jsonOutput = JsonSerializer.Serialize(listAttempts, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(outputPath, jsonOutput);

            MessageBox.Show("Jawaban berhasil disimpan. Terima kasih!");

            // Kembali ke menu pelajar
            MenuPelajar menu = new MenuPelajar(loginData);
            menu.Show();
            this.Close();
        }

        // Event tombol "Kembali ke Menu" ditekan
        private void button1_Click_2(object sender, EventArgs e)
        {
            MenuPelajar menu = new MenuPelajar(loginData);
            menu.Show();
            this.Close();
        }

        // Fungsi untuk menghitung nilai akhir (dalam persen)
        private double HitungNilai(List<JawabanPengguna> ljp)
        {
            if (ljp.Count == 0) return 0;

            double totalSkor = ljp.Sum(jp => jp.Skor);
            return (totalSkor / ljp.Count) * 100;
        }

        // Event klik label - bisa dihapus jika tidak digunakan
        private void labelSoal_Click(object sender, EventArgs e) { }

        private void label1_Click(object sender, EventArgs e) { }

        private void PelajarLevelView_Load(object sender, EventArgs e)
        {

        }
    }
}
