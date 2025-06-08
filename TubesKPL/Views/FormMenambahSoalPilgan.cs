using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoalLibrary;


namespace TubesKPL
{

    public partial class FormMenambahSoalPilgan : Form
    {
        public FormMenambahSoalPilgan()
        {
            InitializeComponent();
        }

        public Soal SoalBaru { get; private set; }

        private void txtSoal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOption_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddOption_Click(object sender, EventArgs e)
        {
            string opsi = txtOption.Text.Trim();
            if (!string.IsNullOrEmpty(opsi))
            {
                lstOptions.Items.Add(opsi);
                txtOption.Clear();
                txtOption.Focus();
            }
            else
            {
                MessageBox.Show("Opsi tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lstOptions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtJawaban_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string soal = txtSoal.Text.Trim();
            string jawaban = txtJawaban.Text.Trim();
            List<string> opsiList = lstOptions.Items.Cast<string>().ToList();

            if (string.IsNullOrEmpty(soal) || opsiList.Count < 2 || string.IsNullOrEmpty(jawaban))
            {
                MessageBox.Show("Pastikan soal, minimal 2 opsi, dan jawaban diisi!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!opsiList.Contains(jawaban))
            {
                MessageBox.Show("Jawaban harus merupakan salah satu dari opsi!", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SoalBaru = new SoalLibrary.Soal
            {
                Pertanyaan = soal,
                Jawaban = jawaban,
                Jenis = SoalLibrary.JenisSoal.PilihanGanda,
                Opsi = opsiList
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void MenambahSoalPilgan_Load(object sender, EventArgs e)
        {

        }
    }
}
