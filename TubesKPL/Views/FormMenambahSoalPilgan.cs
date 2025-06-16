using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace TubesKPL
{
    /// <summary>
    /// Form untuk menambahkan soal pilihan ganda.
    /// </summary>
    public partial class FormMenambahSoalPilgan : Form
    {
        public SoalPilihanGanda SoalBaru { get; private set; }

        public FormMenambahSoalPilgan()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event saat tombol Tambah Opsi diklik.
        /// </summary>
        private void btnAddOption_Click(object sender, EventArgs e)
        {
            string option = txtOption.Text.Trim();

            if (string.IsNullOrWhiteSpace(option))
            {
                ShowWarning("Opsi tidak boleh kosong!");
                return;
            }

            if (lstOptions.Items.Contains(option))
            {
                ShowWarning("Opsi sudah ada dalam daftar.");
                return;
            }

            lstOptions.Items.Add(option);
            txtOption.Clear();
            txtOption.Focus();
        }

        /// <summary>
        /// Event saat tombol Simpan diklik.
        /// </summary>
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string pertanyaan = txtSoal.Text.Trim();
            string jawaban = txtJawaban.Text.Trim();
            List<string> opsiList = lstOptions.Items.Cast<string>().ToList();

            if (!IsValidInput(pertanyaan, jawaban, opsiList)) return;

            try
            {
                SoalPilihanGanda soal = new SoalPilihanGanda(pertanyaan);

                foreach (string opsi in opsiList)
                {
                    soal.TambahOpsi(opsi);
                }

                soal.SetJawabanBenar(jawaban);
                SoalBaru = soal;

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                ShowError($"Terjadi kesalahan saat menyimpan: {ex.Message}");
            }
        }

        /// <summary>
        /// Validasi input sebelum menyimpan.
        /// </summary>
        private bool IsValidInput(string pertanyaan, string jawaban, List<string> opsiList)
        {
            if (string.IsNullOrWhiteSpace(pertanyaan))
            {
                ShowWarning("Pertanyaan tidak boleh kosong.");
                return false;
            }

            if (opsiList.Count < 2)
            {
                ShowWarning("Minimal harus ada 2 opsi.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(jawaban))
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

        /// <summary>
        /// Tampilkan pesan peringatan.
        /// </summary>
        private void ShowWarning(string message)
        {
            MessageBox.Show(message, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// Tampilkan pesan error.
        /// </summary>
        private void ShowError(string message)
        {
            MessageBox.Show(message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Event tombol kembali.
        /// </summary>
        private void Button_Kembali_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
