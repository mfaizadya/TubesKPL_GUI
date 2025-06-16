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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace TubesKPL
{
    public partial class FormMenambahSoalEssay : Form, IFormInputSoal<Soal>
    {

        private Soal soalBaru;
        
        public FormMenambahSoalEssay()
        {
            InitializeComponent();            
        }

        public Soal AmbilSoal()
        {
            return soalBaru;
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            string pertanyaan = textBoxPertanyaan.Text.Trim();
            string jawaban = textBoxJawaban.Text.Trim();

            if (string.IsNullOrEmpty(pertanyaan) || string.IsNullOrEmpty(jawaban))
            {
                MessageBox.Show("Pertanyaan dan jawaban tidak boleh kosong!");
                return;
            }

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

        private void Button_Kembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMenambahSoalEssay_Load(object sender, EventArgs e)
        {

        }
    }
}
