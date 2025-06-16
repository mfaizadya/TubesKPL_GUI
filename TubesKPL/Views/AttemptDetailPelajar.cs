using AuthAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TubesKPL.Views
{
    public partial class AttemptDetailPelajar : Form
    {
        private Attempt attempt;
        private List<Level> levels;
        private LoginResponse loginData;

        private void AttemptDetailPelajar_Load(object sender, EventArgs e)
        {

        }

        public AttemptDetailPelajar()
        {
            InitializeComponent();
        }

        public AttemptDetailPelajar(Attempt attempt, LoginResponse loginData)
        {
            InitializeComponent();
            this.attempt = attempt;
            this.loginData = loginData;
            LoadLevelData();
            TampilkanDetail();
        }

        private void LoadLevelData()
        {
            string json = File.ReadAllText("data_level.json");
            levels = JsonSerializer.Deserialize<List<Level>>(json) ?? new List<Level>();
        }

        private void TampilkanDetail()
        {
            Level level = levels.FirstOrDefault(l => l.NamaLevel == attempt.Level);
            if (level == null) return;

            DataTable table = new DataTable();
            table.Columns.Add("ID Soal");
            table.Columns.Add("Pertanyaan");
            table.Columns.Add("Jawaban User");
            table.Columns.Add("Kunci Jawaban");
            table.Columns.Add("Nilai");

            foreach (var jawaban in attempt.ListJawaban)
            {
                var soal = level.SoalList.FirstOrDefault(s => s.Id == jawaban.IdSoal);
                if (soal != null)
                {
                    table.Rows.Add(soal.Id, soal.Pertanyaan, jawaban.Jawaban, soal.Jawaban, jawaban.Skor);
                }
            }

            dataGridViewDetail.DataSource = table;
        }


        private void back_Click(object sender, EventArgs e)
        {
            // Navigasi ke form review attempt dengan data pelajar
            AttemptReview formAttemptReview = new AttemptReview("pelajar", loginData);
            formAttemptReview.Show();

            // Tutup form saat ini
            this.Close();
        }
    }
}
