using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.Json;
using System.IO;
using System.Windows.Forms;
using AuthAPI;
using SoalLibrary;

namespace TubesKPL
{
    public partial class KelolaLevelDanSoal : Form
    {
        private List<Level> daftarLevel = new List<Level>();
        private readonly string filePath = "data_level.json";
        private readonly LoginResponse loginData;

        public KelolaLevelDanSoal(LoginResponse loginData)
        {
            InitializeComponent();
            this.loginData = loginData;
        }

        // Load data level dari file saat form dimuat
        private void KelolaLevelDanSoal_Load(object sender, EventArgs e)
        {
            if (File.Exists(filePath))
            {
                try
                {
                    string json = File.ReadAllText(filePath);
                    daftarLevel = JsonSerializer.Deserialize<List<Level>>(json) ?? new List<Level>();
                }
                catch (JsonException)
                {
                    MessageBox.Show("File data rusak atau tidak dapat dibaca.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    daftarLevel = new List<Level>();
                }
            }

            RefreshListBox();
        }

        // Tambah level baru
        private void ButtonTambahLevel_Click(object sender, EventArgs e)
        {
            string inputNamaLevel = KelolaLevelHelper.ShowDialog("Masukkan nama level baru:", "Tambah Level");

            if (!string.IsNullOrWhiteSpace(inputNamaLevel))
            {
                int newId = daftarLevel.Any() ? daftarLevel.Max(lv => lv.IdLevel) + 1 : 1;

                daftarLevel.Add(new Level
                {
                    IdLevel = newId,
                    NamaLevel = inputNamaLevel,
                    SoalList = new List<Soal>()
                });

                SimpanDataKeFile();
                RefreshListBox();
            }
        }

        // Edit nama level yang dipilih
        private void ButtonEditLevel_Click(object sender, EventArgs e)
        {
            if (listBoxLevel.SelectedIndex >= 0)
            {
                Level selectedLevel = daftarLevel[listBoxLevel.SelectedIndex];

                string inputNamaBaru = KelolaLevelHelper.ShowDialog("Edit nama level:", "Edit Level", selectedLevel.NamaLevel);

                if (!string.IsNullOrWhiteSpace(inputNamaBaru))
                {
                    selectedLevel.NamaLevel = inputNamaBaru;
                    SimpanDataKeFile();
                    RefreshListBox();
                }
            }
        }

        // Hapus level yang dipilih
        private void ButtonHapusLevel_Click(object sender, EventArgs e)
        {
            if (listBoxLevel.SelectedIndex >= 0)
            {
                var konfirmasi = MessageBox.Show("Yakin ingin menghapus level ini?", "Konfirmasi", MessageBoxButtons.YesNo);

                if (konfirmasi == DialogResult.Yes)
                {
                    daftarLevel.RemoveAt(listBoxLevel.SelectedIndex);
                    SimpanDataKeFile();
                    RefreshListBox();
                }
            }
        }

        // Kelola soal dari level yang dipilih
        private void ButtonKelolaSoal_Click(object sender, EventArgs e)
        {
            if (listBoxLevel.SelectedIndex >= 0)
            {
                Level selectedLevel = daftarLevel[listBoxLevel.SelectedIndex];

                KelolaSoal formKelolaSoal = new KelolaSoal(selectedLevel, loginData);
                formKelolaSoal.Show();

                this.Close(); // Tutup form saat ini
            }
        }

        // Placeholder event jika label diklik
        private void Label1_Click(object sender, EventArgs e)
        {
            
        }

        // Refresh isi listbox untuk menampilkan daftar level
        private void RefreshListBox()
        {
            listBoxLevel.Items.Clear();

            foreach (var level in daftarLevel)
            {
                listBoxLevel.Items.Add($"{level.IdLevel} - {level.NamaLevel}");
            }

            // Nonaktifkan tombol edit, hapus, dan kelola soal saat tidak ada yang dipilih
            buttonEditLevel.Enabled = false;
            buttonHapusLevel.Enabled = false;
            
        }

        // Aktifkan tombol saat item dipilih
        private void ListBoxLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isSelected = listBoxLevel.SelectedIndex >= 0;
            buttonEditLevel.Enabled = isSelected;
            buttonHapusLevel.Enabled = isSelected;
        }

        // Simpan data level ke file JSON
        private void SimpanDataKeFile()
        {
            try
            {
                string json = JsonSerializer.Serialize(daftarLevel, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, json);
            }
            catch (IOException)
            {
                MessageBox.Show("Gagal menyimpan data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Kembali ke menu admin
        private void ButtonBack_Click(object sender, EventArgs e)
        {
            MenuAdmin formMenuAdmin = new MenuAdmin(loginData);
            formMenuAdmin.Show();

            this.Close();
        }
    }
}