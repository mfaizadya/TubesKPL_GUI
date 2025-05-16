using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using System.Text.Json;


namespace TubesKPL
{
    public partial class KelolaSoal : Form
    {
        private Level levelYangDipilih;
        string filePath = "data_level.json";
        public KelolaSoal(Level selectedLevel)
        {
            InitializeComponent();
            levelYangDipilih = selectedLevel;
        }
        private void SimpanLevelKeFile()
        {
            // Jika simpan semua level di form utama, gunakan list global
            // Kalau tidak, load dan replace level by ID
            List<Level> semuaLevel = JsonSerializer.Deserialize<List<Level>>(File.ReadAllText(filePath));
            var index = semuaLevel.FindIndex(l => l.IdLevel == levelYangDipilih.IdLevel);
            if (index >= 0)
            {
                semuaLevel[index] = levelYangDipilih;
                string json = JsonSerializer.Serialize(semuaLevel, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, json);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnTambahSoal_Click(object sender, EventArgs e)
        {
            SimpanLevelKeFile();
        }

        private void btnHapusSoalEssay_Click(object sender, EventArgs e)
        {
            SimpanLevelKeFile();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnHapusSoal_Click(object sender, EventArgs e)
        {
            SimpanLevelKeFile();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

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

        private void btnEditSoalEssay_Click(object sender, EventArgs e)
        {
            SimpanLevelKeFile();
        }

        private void btnEditSoalPG_Click(object sender, EventArgs e)
        {
            SimpanLevelKeFile();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kelola_Level_dan_Soal formkelolalv = new Kelola_Level_dan_Soal();
            formkelolalv.Show();
            this.Hide();
        }
    }
}
