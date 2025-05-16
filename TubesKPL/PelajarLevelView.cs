using AuthAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TubesKPL
{
    public partial class PelajarLevelView : Form
    {
        Level level;
        int currentSoalIndex = 0;
        LoginResponse loginData;

        public PelajarLevelView(Level level, LoginResponse loginData)
        {
            InitializeComponent();
            this.loginData = loginData;
            this.level = level;
            labelLevel.Text = $"Level {level.IdLevel}!";
            LoadSoal();
        }
        public class JawabanPengguna
        {
            public int IdSoal { get; set; }
            public string Jawaban { get; set; } = "";
        }

        List<JawabanPengguna> jawabanUser = new List<JawabanPengguna>();

        private void LoadSoal()
        {
            if (level.SoalList != null && level.SoalList.Count > 0 && currentSoalIndex < level.SoalList.Count)
            {
                var soal = level.SoalList[currentSoalIndex];
                labelSoal.Text = soal.Pertanyaan;

                if (soal.Jenis == JenisSoal.Esai)
                {
                    txtJawaban.Visible = true;
                    txtJawaban.Text = ""; // kosong untuk input
                    listBoxOpsi.Visible = false;
                }
                else if (soal.Jenis == JenisSoal.PilihanGanda)
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

                // Tampilkan tombol selesai hanya di soal terakhir
                if (currentSoalIndex == level.SoalList.Count - 1)
                {
                    buttonSelesai.Visible = true;
                    buttonNext.Visible = false;
                }
                else
                {
                    buttonSelesai.Visible = false;
                }
            }
        }

        private void SimpanJawabanSaatIni()
        {
            var soal = level.SoalList[currentSoalIndex];
            string jawaban = "";

            if (soal.Jenis == JenisSoal.Esai)
            {
                jawaban = txtJawaban.Text.Trim();
            }
            else if (soal.Jenis == JenisSoal.PilihanGanda && listBoxOpsi.SelectedItem != null)
            {
                jawaban = listBoxOpsi.SelectedItem.ToString();
            }

            // Cek apakah jawaban untuk soal ini sudah ada
            var existing = jawabanUser.FirstOrDefault(j => j.IdSoal == soal.Id);
            if (existing != null)
            {
                existing.Jawaban = jawaban;
            }
            else
            {
                jawabanUser.Add(new JawabanPengguna { IdSoal = soal.Id, Jawaban = jawaban });
            }
        }


        private void labelSoal_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

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

        private void button1_Click_1(object sender, EventArgs e)
        {
            SimpanJawabanSaatIni();

            string outputPath = $"jawaban_{loginData.nama}.json";
            string jsonOutput = JsonSerializer.Serialize(jawabanUser, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(outputPath, jsonOutput);

            MessageBox.Show("Jawaban berhasil disimpan. Terima kasih!");

            MenuPelajar menu = new MenuPelajar(loginData);
            menu.Show();
            this.Close();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            MenuPelajar menu = new MenuPelajar(loginData);
            menu.Show();
            this.Close();
        }
    }
}
