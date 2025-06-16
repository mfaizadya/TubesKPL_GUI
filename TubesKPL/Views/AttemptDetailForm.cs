using AuthAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace TubesKPL.Views
{
    public partial class AttemptDetailForm : Form
    {
        // Fields untuk menyimpan data saat form dibuka
        private Attempt _attempt;
        private List<Level> _levels;
        private LoginResponse _loginData;

        // Nama file konstan untuk menghindari magic string
        private const string LevelFilePath = "data_level.json";
        private const string AttemptFilePath = "data_attempt.json";

        public AttemptDetailForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Konstruktor utama dengan parameter data attempt dan login.
        /// </summary>
        public AttemptDetailForm(Attempt attempt, LoginResponse loginData)
        {
            InitializeComponent();

            _attempt = attempt ?? throw new ArgumentNullException(nameof(attempt));
            _loginData = loginData ?? throw new ArgumentNullException(nameof(loginData));

            LoadLevelData();
            DisplayAttemptDetail();
        }

        private void AttemptDetailForm_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Membaca data level dari file JSON ke list of Level.
        /// </summary>
        private void LoadLevelData()
        {
            if (!File.Exists(LevelFilePath))
            {
                MessageBox.Show("File level tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _levels = new List<Level>();
                return;
            }

            string jsonContent = File.ReadAllText(LevelFilePath);
            _levels = JsonSerializer.Deserialize<List<Level>>(jsonContent) ?? new List<Level>();
        }

        /// <summary>
        /// Menampilkan data detail attempt ke dalam DataGridView.
        /// </summary>
        private void DisplayAttemptDetail()
        {
            Level currentLevel = _levels.FirstOrDefault(l => l.NamaLevel == _attempt.Level);
            if (currentLevel == null)
            {
                MessageBox.Show("Level tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataTable detailTable = new DataTable();
            detailTable.Columns.Add("ID Soal", typeof(int));
            detailTable.Columns.Add("Pertanyaan", typeof(string));
            detailTable.Columns.Add("Jawaban User", typeof(string));
            detailTable.Columns.Add("Kunci Jawaban", typeof(string));
            detailTable.Columns.Add("Nilai", typeof(double));

            foreach (var jawaban in _attempt.ListJawaban)
            {
                var soal = currentLevel.SoalList.FirstOrDefault(s => s.Id == jawaban.IdSoal);
                if (soal != null)
                {
                    detailTable.Rows.Add(soal.Id, soal.Pertanyaan, jawaban.Jawaban, soal.Jawaban, jawaban.Skor);
                }
            }

            dataGridViewDetail.DataSource = detailTable;
        }

        /// <summary>
        /// Event handler saat tombol Simpan diklik.
        /// </summary>
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateScoresFromDataGrid();
                CalculateTotalScore();
                SaveUpdatedAttempt();

                MessageBox.Show("Nilai berhasil diperbarui.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saat menyimpan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Mengambil nilai skor dari DataGridView ke dalam objek Attempt.
        /// </summary>
        private void UpdateScoresFromDataGrid()
        {
            foreach (DataGridViewRow row in dataGridViewDetail.Rows)
            {
                if (row.IsNewRow) continue;

                if (row.Cells["ID Soal"].Value is null || row.Cells["Nilai"].Value is null) continue;

                int idSoal = Convert.ToInt32(row.Cells["ID Soal"].Value);
                string nilaiStr = row.Cells["Nilai"].Value.ToString();

                if (double.TryParse(nilaiStr, out double skor))
                {
                    var jawaban = _attempt.ListJawaban.FirstOrDefault(j => j.IdSoal == idSoal);
                    if (jawaban != null)
                        jawaban.Skor = skor;
                }
            }
        }

        /// <summary>
        /// Menghitung ulang skor total attempt berdasarkan rata-rata skor semua jawaban.
        /// </summary>
        private void CalculateTotalScore()
        {
            _attempt.Score = (int)(_attempt.ListJawaban.Average(j => j.Skor) * 100);
        }

        /// <summary>
        /// Menyimpan data attempt yang telah diperbarui ke file JSON.
        /// </summary>
        private void SaveUpdatedAttempt()
        {
            if (!File.Exists(AttemptFilePath))
            {
                MessageBox.Show("File attempt tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string jsonContent = File.ReadAllText(AttemptFilePath);
            var allAttempts = JsonSerializer.Deserialize<List<Attempt>>(jsonContent) ?? new List<Attempt>();

            var targetAttempt = allAttempts.FirstOrDefault(a => a.AttemptId == _attempt.AttemptId);
            if (targetAttempt != null)
            {
                targetAttempt.ListJawaban = _attempt.ListJawaban;
                targetAttempt.Score = _attempt.Score;
            }

            string updatedJson = JsonSerializer.Serialize(allAttempts, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(AttemptFilePath, updatedJson);
        }
    }
}
