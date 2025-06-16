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
        private Attempt attempt;
        private List<Level> levels;

        // Konstruktor default
        public AttemptDetailForm()
        {
            InitializeComponent();
        }

        // Konstruktor dengan parameter Attempt
        // Digunakan untuk menampilkan data attempt yang dipilih
        public AttemptDetailForm(Attempt attempt)
        {
            InitializeComponent();
            this.attempt = attempt;
            LoadLevelData();     // Muat data level dari file
            TampilkanDetail();   // Tampilkan detail jawaban di DataGridView
        }

        private void AttemptDetailForm_Load(object sender, EventArgs e)
        {

        }

        // Membaca data level dari file JSON dan deserialisasi ke list
        private void LoadLevelData()
        {
            string json = File.ReadAllText("data_level.json");
            levels = JsonSerializer.Deserialize<List<Level>>(json) ?? new List<Level>();
        }

        // Menampilkan detail jawaban ke dalam DataGridView
        // Mengisi kolom ID Soal, Pertanyaan, Jawaban User, Kunci Jawaban, dan Nilai
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

        // Event handler tombol "Simpan"
        // Mengambil nilai dari DataGridView, menyimpan ke dalam objek Attempt,
        // menghitung skor total, dan menyimpan ke file JSON
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridViewDetail.Rows)
                {
                    if (row.IsNewRow) continue;

                    object idSoalObj = row.Cells["ID Soal"].Value;
                    object nilaiObj = row.Cells["Nilai"].Value;

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

                // Hitung ulang skor total dari rata-rata skor tiap jawaban
                attempt.Score = (int)(attempt.ListJawaban.Average(j => j.Skor) * 100);

                // Simpan ke file JSON
                SimpanPerubahan();

                MessageBox.Show("Nilai berhasil diperbarui.", "Sukses");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saat menyimpan: " + ex.Message);
            }
        }

        // Simpan data Attempt yang telah diperbarui ke dalam file JSON
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
