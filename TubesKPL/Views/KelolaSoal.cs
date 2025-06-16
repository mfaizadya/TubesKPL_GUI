using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;
using SoalLibrary;
using AuthAPI;

namespace TubesKPL
{
    public partial class KelolaSoal : Form
    {
        private Level levelYangDipilih;
        private readonly string filePath = "data_level.json";
        private readonly LoginResponse loginData;

        public KelolaSoal(Level selectedLevel, LoginResponse loginData)
        {
            InitializeComponent();
            this.levelYangDipilih = selectedLevel;
            this.loginData = loginData;
        }

        // Menyimpan level ke file JSON, dengan penggantian berdasarkan ID level
        private void SimpanLevelKeFile()
        {
            try
            {
                if (!File.Exists(filePath))
                    return;

                var semuaLevel = JsonSerializer.Deserialize<List<Level>>(File.ReadAllText(filePath)) ?? new List<Level>();

                var index = semuaLevel.FindIndex(l => l.IdLevel == levelYangDipilih.IdLevel);

                if (index >= 0)
                {
                    semuaLevel[index] = levelYangDipilih;
                    string json = JsonSerializer.Serialize(semuaLevel, new JsonSerializerOptions { WriteIndented = true });
                    File.WriteAllText(filePath, json);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan saat menyimpan data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Tombol untuk menambah soal essay
        private void button2_Click(object sender, EventArgs e)
        {
            TambahSoalDenganForm<Soal>(new FormMenambahSoalEssay());
        }

        // Metode umum untuk menambah soal dari form
        private void TambahSoalDenganForm<T>(Form formInput) where T : Soal
        {
            if (formInput.ShowDialog() == DialogResult.OK)
            {
                var inputForm = formInput as IFormInputSoal<T>;
                var soal = inputForm?.AmbilSoal();

                if (soal != null)
                {
                    soal.Id = levelYangDipilih.SoalList.Count > 0
                        ? levelYangDipilih.SoalList.Max(s => s.Id) + 1
                        : 1;

                    levelYangDipilih.SoalList.Add(soal);
                    SimpanLevelKeFile();
                    LoadSoalToListView();
                }
            }
        }

        // Tombol untuk menambah soal pilihan ganda
        private void btnTambahSoal_Click(object sender, EventArgs e)
        {
            FormMenambahSoalPilgan formInput = new FormMenambahSoalPilgan();

            if (formInput.ShowDialog() == DialogResult.OK)
            {
                var soal = formInput.SoalBaru;

                if (soal != null)
                {
                    soal.Id = levelYangDipilih.SoalList.Count > 0
                        ? levelYangDipilih.SoalList.Max(s => s.Id) + 1
                        : 1;

                    levelYangDipilih.SoalList.Add(soal);
                    SimpanLevelKeFile();
                    LoadSoalToListView();
                }
            }
        }

        // Tombol hapus soal umum
        private void btnHapusSoal_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string idText = listView1.SelectedItems[0].Text;

                if (int.TryParse(idText, out int id))
                {
                    var soal = levelYangDipilih.SoalList.FirstOrDefault(s => s.Id == id);

                    if (soal != null)
                    {
                        var result = MessageBox.Show("Yakin ingin menghapus soal ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (result == DialogResult.Yes)
                        {
                            levelYangDipilih.SoalList.Remove(soal);
                            SimpanLevelKeFile();
                            LoadSoalToListView();
                        }
                    }
                }
            }
        }

        // Load tampilan awal list soal ke ListView
        private void KelolaSoal_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;

            listView1.Columns.Add("ID", 50);
            listView1.Columns.Add("Jenis", 100);
            listView1.Columns.Add("Pertanyaan", 200);
            listView1.Columns.Add("Jawaban", 200);
            listView1.Columns.Add("Opsi", 200);

            LoadSoalToListView();
        }

        // Mengisi data soal ke dalam ListView
        private void LoadSoalToListView()
        {
            listView1.Items.Clear();

            foreach (var soal in levelYangDipilih.SoalList)
            {
                ListViewItem item = new ListViewItem(soal.Id.ToString());

                string jenis = soal.Jenis == JenisSoal.Esai ? "Esai" : "Pilihan Ganda";

                item.SubItems.Add(jenis);
                item.SubItems.Add(soal.Pertanyaan);
                item.SubItems.Add(soal.Jawaban);

                string opsiText = soal.Opsi != null ? string.Join(", ", soal.Opsi) : "-";
                item.SubItems.Add(opsiText);

                listView1.Items.Add(item);
            }
        }

        // Edit soal esai
        private void btnEditSoalEssay_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string idText = listView1.SelectedItems[0].Text;

                if (int.TryParse(idText, out int id))
                {
                    var soal = levelYangDipilih.SoalList.FirstOrDefault(s => s.Id == id && s.Jenis == JenisSoal.Esai);

                    if (soal != null && SoalEditHelper.EditEsaiSoal(soal))
                    {
                        SimpanLevelKeFile();
                        LoadSoalToListView();
                    }
                }
            }
        }

        // Edit soal pilihan ganda
        private void btnEditSoalPG_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string idText = listView1.SelectedItems[0].Text;

                if (int.TryParse(idText, out int id))
                {
                    var soal = levelYangDipilih.SoalList.FirstOrDefault(s => s.Id == id && s.Jenis == JenisSoal.PilihanGanda);

                    if (soal != null && SoalEditHelper.EditPilihanGandaSoal(soal))
                    {
                        SimpanLevelKeFile();
                        LoadSoalToListView();
                    }
                }
            }
        }

        // Tombol kembali ke form level
        private void button1_Click(object sender, EventArgs e)
        {
            Kelola_Level_dan_Soal formkelolalv = new Kelola_Level_dan_Soal(loginData);
            formkelolalv.Show();
            this.Hide();
        }

        // Kosong, event handler tidak dipakai
        private void listView1_SelectedIndexChanged(object sender, EventArgs e) { }

        private void btnHapusSoalEssay_Click(object sender, EventArgs e)
        {
            SimpanLevelKeFile(); // Dipakai untuk autosave jika perlu
        }

        private void label1_Click(object sender, EventArgs e) { }
    }
}