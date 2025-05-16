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
    public partial class NilaiEsai : Form
    {
        private Dictionary<string, string> jawabanPelajar = new Dictionary<string, string>();

        public NilaiEsai()
        {
            InitializeComponent();
            InitDummyData();
            InitForm();
        }

        private void InitDummyData()
        {
            // Dummy data: ID pelajar -> jawaban esai
            jawabanPelajar.Add("P001", "Jawaban esai pelajar P001 tentang pentingnya OOP...");
            jawabanPelajar.Add("P002", "Pelajar P002 menjelaskan tentang inheritance dan polymorphism...");
            jawabanPelajar.Add("P003", "Pelajar P003 membahas SOLID principles dengan detail...");

            cmbPelajar.Items.AddRange(jawabanPelajar.Keys.ToArray());
        }

        private void InitForm()
        {
            txtJawabanEsai.ReadOnly = true;
            txtJawabanEsai.Multiline = true;
        }

        private void cmbPelajar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPelajar.SelectedItem == null) return; // <- Tambahan untuk cegah null

            string selectedId = cmbPelajar.SelectedItem.ToString();

            if (jawabanPelajar.ContainsKey(selectedId))
            {
                txtJawabanEsai.Text = jawabanPelajar[selectedId];
            }
        }

        private void txtJawabanEsai_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSkorMax_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSkorPelajar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (cmbPelajar.SelectedItem == null)
            {
                MessageBox.Show("Silakan pilih pelajar terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(txtSkorMax.Text.Trim(), out double skorMax) || skorMax == 0)
            {
                MessageBox.Show("Skor maksimal harus berupa angka dan lebih dari 0.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtSkorPelajar.Text.Trim(), out double skorPelajar) || skorPelajar < 0 || skorPelajar > skorMax)
            {
                MessageBox.Show("Skor pelajar tidak valid atau melebihi skor maksimal.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string id = cmbPelajar.SelectedItem.ToString();
            MessageBox.Show($"Penilaian disimpan:\nID Pelajar: {id}\nSkor: {skorPelajar}/{skorMax}", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Reset form setelah simpan
            cmbPelajar.SelectedIndex = -1;
            txtJawabanEsai.Clear();
            txtSkorMax.Clear();
            txtSkorPelajar.Clear();
        }
    }
}
