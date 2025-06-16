using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AuthAPI;
using SoalLibrary;

namespace TubesKPL
{
    public partial class FormMenambahSoalEssay : Form, IFormInputSoal<Soal>
    {
        private Soal soalBaru;

        public FormMenambahSoalEssay()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Mengembalikan soal yang sudah diisi dari form.
        /// </summary>
        public Soal AmbilSoal()
        {
            return soalBaru;
        }

        /// <summary>
        /// Event ketika tombol "Selesai" diklik. Memvalidasi input dan menyimpan soal.
        /// </summary>
        private void BtnSelesai_Click(object sender, EventArgs e)
        {
            string pertanyaan = textBoxPertanyaan.Text.Trim();
            string jawaban = textBoxJawaban.Text.Trim();

            // Validasi input tidak boleh kosong
            if (string.IsNullOrEmpty(pertanyaan) || string.IsNullOrEmpty(jawaban))
            {
                MessageBox.Show("Pertanyaan dan jawaban tidak boleh kosong!");
                return;
            }

            try
            {
                //MemBuat objek soal baru dengan input aman
                soalBaru = new Soal
                {
                    Pertanyaan = pertanyaan,
                    Jawaban = jawaban,
                    Jenis = JenisSoal.Esai,
                    Opsi = null
                };

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat menyimpan soal: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Event untuk kembali ke form sebelumnya tanpa menyimpan.
        /// </summary>
        private void BtnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Event load form
        /// </summary>
        private void FormMenambahSoalEssay_Load(object sender, EventArgs e)
        {
            
        }
    }
}
