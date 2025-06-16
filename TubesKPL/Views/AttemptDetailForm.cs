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
    public partial class AttemptDetailForm : Form
    {
        private Attempt attempt;
        private List<Level> levels;
        private LoginResponse loginData;

        private void AttemptDetailForm_Load(object sender, EventArgs e)
        {

        }

        public AttemptDetailForm()
        {
            InitializeComponent();
        }

        public AttemptDetailForm(Attempt attempt, LoginResponse loginData)
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

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridViewDetail.Rows)
                {
                    if (row.IsNewRow) continue;

                    object idSoalObj = row.Cells["ID Soal"].Value;
                    object nilaiObj = row.Cells["Nilai"].Value;

                    // Lewati jika salah satu nilai null
                    if (idSoalObj == null || nilaiObj == null) continue;

                    int idSoal = Convert.ToInt32(idSoalObj);
                    string nilaiStr = nilaiObj.ToString();

                    if (double.TryParse(nilaiStr, out double skor))
                    {
                        var jawaban = attempt.ListJawaban.FirstOrDefault(j => j.IdSoal == idSoal);
                        if (jawaban != null)
                            jawaban.Skor = skor;
                    }
                }

                // update score total
                attempt.Score = (int)(attempt.ListJawaban.Average(j => j.Skor) * 100);
                SimpanPerubahan();
                MessageBox.Show("Nilai berhasil diperbarui.", "Sukses");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saat menyimpan: " + ex.Message);
            }
        }

        private void SimpanPerubahan()
        {
            string jsonFile = "data_attempt.json";
            var allAttempts = JsonSerializer.Deserialize<List<Attempt>>(File.ReadAllText(jsonFile)) ?? new List<Attempt>();

            var target = allAttempts.FirstOrDefault(a => a.AttemptId == attempt.AttemptId);
            if (target != null)
            {
                target.ListJawaban = attempt.ListJawaban;
                target.Score = attempt.Score;
            }

            File.WriteAllText(jsonFile, JsonSerializer.Serialize(allAttempts, new JsonSerializerOptions { WriteIndented = true }));
        }
    }
}
