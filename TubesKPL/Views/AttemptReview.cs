using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;
using AuthAPI;
using TubesKPL.Views;

namespace TubesKPL
{
    public partial class AttemptReview : Form
    {
        private List<Attempt> attempts;
        private string role;
        private LoginResponse loginData;

        /// <summary>
        /// Konstruktor utama AttemptReview. Menyimpan data login dan memuat attempt.
        /// </summary>
        public AttemptReview(string role, LoginResponse loginData)
        {
            InitializeComponent();
            this.role = role;
            this.loginData = loginData;

            try
            {
                this.LoadAttempts(this.role, this.loginData.username);
                this.DisplayAttempts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Terjadi kesalahan saat memuat data attempt: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void AttemptReview_Load(object sender, EventArgs e) { }

        /// <summary>
        /// Memuat data attempt dari file JSON dan memfilter berdasarkan role.
        /// </summary>
        private void LoadAttempts(string role, string username)
        {
            string dataPath = "data_attempt.json";
            var allAttempts = new List<Attempt>();

            try
            {
                if (File.Exists(dataPath))
                {
                    string jsonContent = File.ReadAllText(dataPath);
                    allAttempts = JsonSerializer.Deserialize<List<Attempt>>(jsonContent) ?? new List<Attempt>();
                }

                this.attempts = role == "admin"
                    ? allAttempts
                    : allAttempts.Where(a => a.UserName == username).ToList();
            }
            catch (JsonException je)
            {
                MessageBox.Show($"Format data JSON tidak valid: {je.Message}", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (IOException ie)
            {
                MessageBox.Show($"Kesalahan saat membaca file: {ie.Message}", "IO Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Menampilkan data attempt ke dalam DataGridView.
        /// </summary>
        private void DisplayAttempts()
        {
            dataGridViewAttempt.DataSource = null;
            dataGridViewAttempt.DataSource = this.attempts;
        }

        /// <summary>
        /// Event handler untuk tombol "Back". Mengarahkan pengguna ke menu sesuai rolenya.
        /// </summary>
        private void ButtonBack_Click(object sender, EventArgs e)
        {
            if (this.role == "admin")
            {
                var adminMenu = new MenuAdmin(this.loginData);
                adminMenu.Show();
            }
            else
            {
                var studentMenu = new MenuPelajar(this.loginData);
                studentMenu.Show();
            }

            this.Close();
        }

        /// <summary>
        /// Event handler untuk tombol "Detail". Menampilkan form detail dari attempt yang dipilih.
        /// </summary>
        private void ButtonDetail_Click(object sender, EventArgs e)
        {
            if (dataGridViewAttempt.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih salah satu data attempt!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Attempt selectedAttempt = dataGridViewAttempt.SelectedRows[0].DataBoundItem as Attempt;
            if (selectedAttempt == null) return;

            Form detailForm = this.role == "admin"
                ? new AttemptDetailForm(selectedAttempt, this.loginData)
                : new AttemptDetailPelajar(selectedAttempt, this.loginData);

            detailForm.ShowDialog();

            // Refresh data setelah form ditutup
            this.LoadAttempts(this.role, this.loginData.username);
            this.DisplayAttempts();
        }
    }
}
