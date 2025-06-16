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

        // Event tombol tambah opsi diklik
        private void btnAddOption_Click(object sender, EventArgs e)
        {
            string opsi = txtOption.Text.Trim();

            if (string.IsNullOrWhiteSpace(opsi))
            {
                ShowWarning("Opsi tidak boleh kosong!");
                return;
            }

            if (lstOptions.Items.Contains(opsi))
            {
                ShowWarning("Opsi sudah ada di dalam list.");
                return;
            }

            lstOptions.Items.Add(opsi);
            txtOption.Clear();
            txtOption.Focus();
        }

        private void lstOptions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtJawaban_TextChanged(object sender, EventArgs e)
        {

        }

        // Event tombol simpan diklik
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string soal = txtSoal.Text.Trim();
            string jawaban = txtJawaban.Text.Trim();
            List<string> opsiList = lstOptions.Items.Cast<string>().ToList();

            if (!IsValidInput(soal, jawaban, opsiList)) return;

            SoalBaru = new Soal
            {
                Pertanyaan = soal,
                Jawaban = jawaban,
                Jenis = JenisSoal.PilihanGanda,
                Opsi = opsiList
            };

            DialogResult = DialogResult.OK;
            Close();
        }

        // Validasi input sebelum membuat object soal
        private bool IsValidInput(string soal, string jawaban, List<string> opsiList)
        {
            if (string.IsNullOrEmpty(soal))
            {
                ShowWarning("Soal tidak boleh kosong.");
                return false;
            }

            if (opsiList.Count < 2)
            {
                ShowWarning("Minimal harus ada 2 opsi.");
                return false;
            }

            if (string.IsNullOrEmpty(jawaban))
            {
                ShowWarning("Jawaban tidak boleh kosong.");
                return false;
            }

            if (!opsiList.Contains(jawaban))
            {
                ShowError("Jawaban harus merupakan salah satu dari opsi.");
                return false;
            }

            return true;
        }

        // Menampilkan pesan peringatan
        private void ShowWarning(string message)
        {
            MessageBox.Show(message, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // Menampilkan pesan error
        private void ShowError(string message)
        {
            MessageBox.Show(message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MenambahSoalPilgan_Load(object sender, EventArgs e)
        {
            
        }

        
    }
}