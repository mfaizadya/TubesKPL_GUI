using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TubesKPL
{
    public partial class Kelola_Level_dan_Soal : Form
    {
        private List<string> daftarLevel = new List<string>();
        public Kelola_Level_dan_Soal()
        {
            InitializeComponent();
        }

        private void Kelola_Level_dan_Soal_Load(object sender, EventArgs e)
        {
            daftarLevel.Add("Level 1");
            daftarLevel.Add("Level 2");
            daftarLevel.Add("Level 3");

            RefreshListBox();
        }

        private void Tambahlv_Click(object sender, EventArgs e)
        {
            string input = KelolaLevelHelper.ShowDialog("Masukkan nama level baru:", "Tambah Level");
            if (!string.IsNullOrWhiteSpace(input))
            {
                daftarLevel.Add(input);
                RefreshListBox();
            }
        }

        private void Editlv_Click(object sender, EventArgs e)
        {
            if (listBoxLevel.SelectedIndex >= 0)
            {
                string current = daftarLevel[listBoxLevel.SelectedIndex];
                string input = KelolaLevelHelper.ShowDialog("Edit nama level:", "Edit Level", current);
                if (!string.IsNullOrWhiteSpace(input))
                {
                    daftarLevel[listBoxLevel.SelectedIndex] = input;
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
                    RefreshListBox();
                }
            }
        }

        private void Kelolalv_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RefreshListBox()
        {
            listBoxLevel.Items.Clear();
            foreach (var level in daftarLevel)
            {
                listBoxLevel.Items.Add(level);
            }
            Editlv.Enabled = false;
            Hapuslv.Enabled = false;
        }

        private void listBoxLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            Editlv.Enabled = listBoxLevel.SelectedIndex >= 0;
            Hapuslv.Enabled = listBoxLevel.SelectedIndex >= 0;
        }
    }
}
