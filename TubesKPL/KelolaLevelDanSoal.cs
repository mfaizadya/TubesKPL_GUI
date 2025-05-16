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


namespace TubesKPL
{
    public partial class Kelola_Level_dan_Soal : Form
    {
        private List<Level> daftarLevel = new List<Level>();
        private string filePath = "data_level.json";
        LoginResponse loginData;
        public Kelola_Level_dan_Soal()
        {
            InitializeComponent();
        }
        public Kelola_Level_dan_Soal(LoginResponse loginData)
        {
            InitializeComponent();
            this.loginData = loginData;
        }

        private void Kelola_Level_dan_Soal_Load(object sender, EventArgs e)
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                daftarLevel = JsonSerializer.Deserialize<List<Level>>(json);
            }
            else
            {
                daftarLevel = new List<Level>();
            }

            RefreshListBox();
        }

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

        private void Kelolalv_Click(object sender, EventArgs e)
        {
            if (listBoxLevel.SelectedIndex >= 0)
            {
                Level selected = daftarLevel[listBoxLevel.SelectedIndex];
                KelolaSoal formKelolaSoal = new KelolaSoal(selected);
                formKelolaSoal.Show();
                this.Close();
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

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

        private void listBoxLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            Editlv.Enabled = listBoxLevel.SelectedIndex >= 0;
            Hapuslv.Enabled = listBoxLevel.SelectedIndex >= 0;
        }
        private void SimpanDataKeFile()
        {
            string json = JsonSerializer.Serialize(daftarLevel, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            MenuAdmin formMenuAdmin = new MenuAdmin();
            formMenuAdmin.Show();
            this.Close();
        }
    }
}
