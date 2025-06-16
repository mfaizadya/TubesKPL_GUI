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
        // Private field untuk menyimpan state form
        private Attempt attempt;
        private List<Level> levels;
        private LoginResponse loginData;

        // Konstanta nama file
        private const string LevelFilePath = "data_level.json";

        public AttemptDetailPelajar()
        {
            InitializeComponent();
        }

        // Constructor utama yang dipakai saat form dipanggil
        public AttemptDetailPelajar(Attempt attempt, LoginResponse loginData)
        {
            InitializeComponent();

            // Validasi null argument agar aman (secure code)
            this.attempt = attempt ?? throw new ArgumentNullException(nameof(attempt));
            this.loginData = loginData ?? throw new ArgumentNullException(nameof(loginData));

            try
            {
                LoadLevelData();   // Load file level
                DisplayDetail();   // Tampilkan data ke grid
            }
            catch (Exception ex)
            {
                // Jika terjadi error, tampilkan pesan
                MessageBox.Show($"Gagal memuat data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AttemptDetailPelajar_Load(object sender, EventArgs e)
        {
        }

        // Method untuk membaca file level dari file JSON
        private void LoadLevelData()
        {
            // Validasi apakah file ada
            if (!File.Exists(LevelFilePath))
                throw new FileNotFoundException($"File level tidak ditemukan: {LevelFilePath}");

            // Baca isi file
            string json = File.ReadAllText(LevelFilePath);

            // Deserialize ke list level, aman terhadap null
            levels = JsonSerializer.Deserialize<List<Level>>(json) ?? new List<Level>();

            // Validasi apakah data kosong
            if (levels.Count == 0)
                throw new Exception("Data level kosong.");
        }

        // Method utama untuk menampilkan data attempt ke DataGridView
        private void DisplayDetail()
        {
            // Cari level yang sesuai dengan level pada attempt
            Level level = levels.FirstOrDefault(l => l.NamaLevel == attempt.Level);
            if (level == null)
                throw new Exception($"Level '{attempt.Level}' tidak ditemukan.");

            // Buat datatable untuk binding ke DataGridView
            DataTable table = new DataTable();
            table.Columns.Add("ID Soal", typeof(int));
            table.Columns.Add("Pertanyaan", typeof(string));
            table.Columns.Add("Jawaban User", typeof(string));
            table.Columns.Add("Kunci Jawaban", typeof(string));
            table.Columns.Add("Nilai", typeof(double));

            // Loop semua jawaban attempt dan masukkan ke tabel
            foreach (var jawaban in attempt.ListJawaban)
            {
                var soal = level.SoalList.FirstOrDefault(s => s.Id == jawaban.IdSoal);
                if (soal != null)
                {
                    table.Rows.Add(soal.Id, soal.Pertanyaan, jawaban.Jawaban, soal.Jawaban, jawaban.Skor);
                }
            }

            // Binding data ke DataGridView
            dataGridViewDetail.DataSource = table;

            // Jadikan semua kolom read-only agar tidak bisa diedit oleh pelajar
            foreach (DataGridViewColumn col in dataGridViewDetail.Columns)
            {
                col.ReadOnly = true;
            }
        }

        // Event handler untuk tombol kembali
        private void back_Click(object sender, EventArgs e)
        {
            try
            {
                // Navigasi ke form AttemptReview untuk role pelajar
                AttemptReview formAttemptReview = new AttemptReview("pelajar", loginData);
                formAttemptReview.Show();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal membuka halaman review: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
