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
        private Level selectedLevel;
        private readonly string filePath = "data_level.json";
        private readonly LoginResponse loginData;

        public KelolaSoal(Level selectedLevel, LoginResponse loginData)
        {
            InitializeComponent();
            this.selectedLevel = selectedLevel;
            this.loginData = loginData;
        }

        
        /// Menyimpan data level ke file JSON.
        
        private void SaveLevelToFile()
        {
            try
            {
                if (!File.Exists(filePath)) return;

                var allLevels = JsonSerializer.Deserialize<List<Level>>(File.ReadAllText(filePath))
                                ?? new List<Level>();

                var index = allLevels.FindIndex(l => l.IdLevel == selectedLevel.IdLevel);

                if (index >= 0)
                {
                    allLevels[index] = selectedLevel;
                    string json = JsonSerializer.Serialize(allLevels, new JsonSerializerOptions { WriteIndented = true });
                    File.WriteAllText(filePath, json);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan saat menyimpan data: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        /// Event klik tombol tambah soal esai.        
        private void BtnTambahSoalEssay_Click(object sender, EventArgs e)
        {
            TambahSoalDenganForm<Soal>(new FormMenambahSoalEssay());
        }

        
        /// Menambahkan soal ke dalam list level melalui form input.        
        private void TambahSoalDenganForm<T>(Form formInput) where T : Soal
        {
            if (formInput.ShowDialog() == DialogResult.OK)
            {
                var inputForm = formInput as IFormInputSoal<T>;
                var soal = inputForm?.AmbilSoal();

                if (soal != null)
                {
                    soal.Id = selectedLevel.SoalList.Count > 0
                        ? selectedLevel.SoalList.Max(s => s.Id) + 1
                        : 1;

                    selectedLevel.SoalList.Add(soal);
                    SaveLevelToFile();
                    LoadSoalToListView();
                }
            }
        }

        
        /// Event klik tombol tambah soal pilihan ganda.        
        private void BtnTambahSoalPG_Click(object sender, EventArgs e)
        {
            var formInput = new FormMenambahSoalPilgan();

            if (formInput.ShowDialog() == DialogResult.OK)
            {
                var soal = formInput.SoalBaru;

                if (soal != null)
                {
                    soal.Id = selectedLevel.SoalList.Count > 0
                        ? selectedLevel.SoalList.Max(s => s.Id) + 1
                        : 1;

                    selectedLevel.SoalList.Add(soal);
                    SaveLevelToFile();
                    LoadSoalToListView();
                }
            }
        }

        
        /// Event klik tombol hapus soal.        
        private void BtnHapusSoal_Click(object sender, EventArgs e)
        {
            if (listSoal.SelectedItems.Count == 0) return;

            string idText = listSoal.SelectedItems[0].Text;

            if (int.TryParse(idText, out int id))
            {
                var soal = selectedLevel.SoalList.FirstOrDefault(s => s.Id == id);

                if (soal != null)
                {
                    var result = MessageBox.Show("Yakin ingin menghapus soal ini?", "Konfirmasi",
                                                 MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        selectedLevel.SoalList.Remove(soal);
                        SaveLevelToFile();
                        LoadSoalToListView();
                    }
                }
            }
        }

        
        /// Menampilkan soal ke dalam ListView.        
        private void LoadSoalToListView()
        {
            listSoal.Items.Clear();

            foreach (var soal in selectedLevel.SoalList)
            {
                var item = new ListViewItem(soal.Id.ToString());

                string jenis = soal.Jenis == JenisSoal.Esai ? "Esai" : "Pilihan Ganda";
                string opsiText = soal.Opsi != null ? string.Join(", ", soal.Opsi) : "";

                item.SubItems.Add(jenis);
                item.SubItems.Add(soal.Pertanyaan);
                item.SubItems.Add(soal.Jawaban);
                item.SubItems.Add(opsiText);

                listSoal.Items.Add(item);
            }
        }

        
        /// Event onLoad form KelolaSoal.        
        private void KelolaSoal_Load(object sender, EventArgs e)
        {
            listSoal.View = View.Details;
            listSoal.FullRowSelect = true;

            listSoal.Columns.Add("ID", 50);
            listSoal.Columns.Add("Jenis", 100);
            listSoal.Columns.Add("Pertanyaan", 200);
            listSoal.Columns.Add("Jawaban", 200);
            listSoal.Columns.Add("Opsi", 200);

            LoadSoalToListView();
        }

        
        /// Edit soal esai.        
        private void BtnEditSoalEssay_Click(object sender, EventArgs e)
        {
            if (listSoal.SelectedItems.Count == 0) return;

            string idText = listSoal.SelectedItems[0].Text;

            if (int.TryParse(idText, out int id))
            {
                var soal = selectedLevel.SoalList
                    .FirstOrDefault(s => s.Id == id && s.Jenis == JenisSoal.Esai);

                if (soal != null && SoalEditHelper.EditEsaiSoal(soal))
                {
                    SaveLevelToFile();
                    LoadSoalToListView();
                }
            }
        }

        
        /// Edit soal pilihan ganda.        
        private void BtnEditSoalPG_Click(object sender, EventArgs e)
        {
            if (listSoal.SelectedItems.Count == 0) return;

            string idText = listSoal.SelectedItems[0].Text;

            if (int.TryParse(idText, out int id))
            {
                var soal = selectedLevel.SoalList
                    .FirstOrDefault(s => s.Id == id && s.Jenis == JenisSoal.PilihanGanda);

                if (soal != null && SoalEditHelper.EditPilihanGandaSoal(soal))
                {
                    SaveLevelToFile();
                    LoadSoalToListView();
                }
            }
        }

        
        /// Kembali ke form Kelola Level.        
        private void BtnKembali_Click(object sender, EventArgs e)
        {
            var formKelolaLevel = new KelolaLevelDanSoal(loginData);
            formKelolaLevel.Show();
            this.Hide();
        }

        // untuk memilih list
        private void listView1_SelectedIndexChanged(object sender, EventArgs e) { }

        private void BtnHapusSoalEssay_Click(object sender, EventArgs e)
        {
            SaveLevelToFile(); // Opsional autosave
        }

        private void LabelTitle_Click(object sender, EventArgs e) { }
    }
}
