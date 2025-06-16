using AuthAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace TubesKPL.Views
{
    public partial class AttemptDetailPelajar : Form
    {
        // Private field untuk menyimpan data state form
        private Attempt _attempt;
        private List<Level> _levels;
        private LoginResponse _loginData;

        // Konstanta file path
        private const string LevelFilePath = "data_level.json";

        public AttemptDetailPelajar()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Konstruktor utama, menerima parameter data attempt dan login.
        /// </summary>
        public AttemptDetailPelajar(Attempt attempt, LoginResponse loginData)
        {
            InitializeComponent();

            // Validasi null argument (secure code)
            _attempt = attempt ?? throw new ArgumentNullException(nameof(attempt));
            _loginData = loginData ?? throw new ArgumentNullException(nameof(loginData));

            try
            {
                LoadLevelData();
                DisplayAttemptDetail();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AttemptDetailPelajar_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Membaca file data level JSON dan melakukan deserialisasi.
        /// </summary>
        private void LoadLevelData()
        {
            if (!File.Exists(LevelFilePath))
                throw new FileNotFoundException($"File level tidak ditemukan: {LevelFilePath}");

            string jsonContent = File.ReadAllText(LevelFilePath);
            _levels = JsonSerializer.Deserialize<List<Level>>(jsonContent) ?? new List<Level>();

            if (_levels.Count == 0)
                throw new Exception("Data level kosong.");
        }

        /// <summary>
        /// Menampilkan data attempt ke dalam DataGridView (read-only).
        /// </summary>
        private void DisplayAttemptDetail()
        {
            // Cari level berdasarkan level attempt
            Level currentLevel = _levels.FirstOrDefault(l => l.NamaLevel == _attempt.Level);
            if (currentLevel == null)
                throw new Exception($"Level '{_attempt.Level}' tidak ditemukan.");

            // Buat datatable binding ke DataGridView
            DataTable detailTable = new DataTable();
            detailTable.Columns.Add("ID Soal", typeof(int));
            detailTable.Columns.Add("Pertanyaan", typeof(string));
            detailTable.Columns.Add("Jawaban User", typeof(string));
            detailTable.Columns.Add("Kunci Jawaban", typeof(string));
            detailTable.Columns.Add("Nilai", typeof(double));

            // Loop semua jawaban attempt untuk mengisi tabel
            foreach (var answer in _attempt.ListJawaban)
            {
                var question = currentLevel.SoalList.FirstOrDefault(s => s.Id == answer.IdSoal);
                if (question != null)
                {
                    detailTable.Rows.Add(question.Id, question.Pertanyaan, answer.Jawaban, question.Jawaban, answer.Skor);
                }
            }

            dataGridViewDetail.DataSource = detailTable;

            // Set semua kolom menjadi read-only (pelajar tidak boleh mengedit)
            foreach (DataGridViewColumn column in dataGridViewDetail.Columns)
            {
                column.ReadOnly = true;
            }
        }

        /// <summary>
        /// Event handler untuk tombol back/kembali.
        /// </summary>
        private void back_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal kembali ke halaman review: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
