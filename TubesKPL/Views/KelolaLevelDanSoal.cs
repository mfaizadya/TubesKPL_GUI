using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;
using AuthAPI;
using SoalLibrary;

namespace TubesKPL
{
    public partial class Kelola_Level_dan_Soal : Form
    {
        private List<Level> daftarLevel = new List<Level>();
        private readonly string filePath = "data_level.json";
        private readonly LoginResponse loginData;

        public Kelola_Level_dan_Soal(LoginResponse loginData)
        {
            InitializeComponent();
            this.loginData = loginData;
        }

        // Load data level dari file saat form dimuat
        private void Kelola_Level_dan_Soal_Load(object sender, EventArgs e)
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

        // Tombol untuk menambahkan level baru
        private void Tambahlv_Click(object sender, EventArgs e)
        {
            string input = KelolaLevelHelper.ShowDialog("Masukkan nama level baru:", "Tambah Level");

            if (!string.IsNullOrWhiteSpace(input))
            {
                int newId = daftarLevel.Any() ? daftarLevel.Max(lv => lv.IdLevel) + 1 : 1;

                daftarLevel.Add(new Level
                {
                    IdLevel = newId,
                    NamaLevel = input,
                    SoalList = new List<Soal>()
                });

                SimpanDataKeFile();
                RefreshListBox();
            }
        }

        // Tombol untuk mengedit level yang dipilih
        private void Editlv_Click(object sender, EventArgs e)
        {
            if (listBoxLevel.SelectedIndex >= 0)
            {
                Level selectedLevel = daftarLevel[listBoxLevel.SelectedIndex];

                string input = KelolaLevelHelper.ShowDialog("Edit nama level:", "Edit Level", selectedLevel.NamaLevel);

                if (!string.IsNullOrWhiteSpace(input))
                {
                    selectedLevel.NamaLevel = input;

                    SimpanDataKeFile();
                    RefreshListBox();
                }
            }
        }

        // Tombol untuk menghapus level yang dipilih
        private void Hapuslv_Click(object sender, EventArgs e)
        {
            if (listBoxLevel.SelectedIndex >= 0)
            {
                var result = MessageBox.Show("Yakin ingin menghapus level ini?", "Konfirmasi", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    daftarLevel.RemoveAt(listBoxLevel.SelectedIndex);

                    SimpanDataKeFile();
                    RefreshListBox();
                }
            }
        }

        // Tombol untuk mengelola soal dari level yang dipilih
        private void Kelolalv_Click(object sender, EventArgs e)
        {
            if (listBoxLevel.SelectedIndex >= 0)
            {
                Level selected = daftarLevel[listBoxLevel.SelectedIndex];

                KelolaSoal formKelolaSoal = new KelolaSoal(selected, loginData);
                formKelolaSoal.Show();

                this.Close(); // Tutup form saat ini
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Kosong - event handler placeholder (bisa dihapus jika tidak digunakan)
        }

        // Menyegarkan isi ListBox untuk menampilkan daftar level
        private void RefreshListBox()
        {
            listBoxLevel.Items.Clear();

            foreach (var level in daftarLevel)
            {
                listBoxLevel.Items.Add($"{level.IdLevel} - {level.NamaLevel}");
            }

            Editlv.Enabled = false;
            Hapuslv.Enabled = false;
        }

        // Mengaktifkan/menonaktifkan tombol edit dan hapus saat item dipilih
        private void listBoxLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isSelected = listBoxLevel.SelectedIndex >= 0;
            Editlv.Enabled = isSelected;
            Hapuslv.Enabled = isSelected;
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

        // Tombol kembali ke menu admin
        private void buttonBack_Click(object sender, EventArgs e)
        {
            MenuAdmin formMenuAdmin = new MenuAdmin(loginData);
            formMenuAdmin.Show();

            this.Close();
        }
    }
}