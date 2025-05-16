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
using Newtonsoft.Json;
using System.IO;

namespace TubesKPL
{
    public partial class KelolaSoal : Form
    {
        public KelolaSoal()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnTambahSoal_Click(object sender, EventArgs e)
        {

        }

        private void btnHapusSoalEssay_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnHapusSoal_Click(object sender, EventArgs e)
        {

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
            try
            {
                string filePath = "soal.json";
                string json = File.ReadAllText(filePath);
                List<Soal> soalList = JsonConvert.DeserializeObject<List<Soal>>(json);

                listView1.Items.Clear();

                foreach (var soal in soalList)
                {
                    ListViewItem item = new ListViewItem(soal.Id.ToString());

                    // Menambahkan kolom-kolom lain
                    string jenis = soal.Jenis == JenisSoal.Esai ? "Esai" : "Pilihan Ganda";
                    item.SubItems.Add(jenis);
                    item.SubItems.Add(soal.Pertanyaan);
                    item.SubItems.Add(soal.Jawaban);

                    string opsiText = "-";
                    if (soal.Jenis == JenisSoal.PilihanGanda && soal.Opsi != null)
                        opsiText = string.Join(", ", soal.Opsi);

                    item.SubItems.Add(opsiText);

                    listView1.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal load soal: " + ex.Message);
            }
        }


    }
}
