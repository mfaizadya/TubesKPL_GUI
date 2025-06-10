using AuthAPI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace TubesKPL
{
    public partial class MenuPelajar : Form
    {
        // List untuk menyimpan data level dari file JSON
        private List<Level> daftarLevel = new List<Level>();

        // Path file tempat data level disimpan
        private readonly string filePath = "data_level.json";

        // Data login pelajar yang sedang aktif
        private readonly LoginResponse loginData;

        // Level yang dipilih saat ini dari list
        private Level selectedLevel;

        // Konstruktor dengan parameter data login pelajar
        public MenuPelajar(LoginResponse loginData)
        {
            InitializeComponent();
            this.loginData = loginData;

            // Menampilkan nama pelajar yang login di label
            labelNama.Text = $"Selamat datang di Logilearn, {loginData.nama}!";
        }

        // Event saat form dimuat
        private void MenuPelajar_Load(object sender, EventArgs e)
        {
            // Load data level dari file JSON jika file ada
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                daftarLevel = JsonSerializer.Deserialize<List<Level>>(json);
            }
            else
            {
                daftarLevel = new List<Level>();
            }

            // Perbarui tampilan ListBox dengan data level
            RefreshListBox();
        }

        private void buttonReviewAttempt_Click(object sender, EventArgs e)
        {
            // Navigasi ke form review attempt dengan data pelajar
            AttemptReview formAttemptReview = new AttemptReview("pelajar", loginData);
            formAttemptReview.Show();

            // Tutup form saat ini
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Atur state aplikasi ke Logout
            AppStateManager.Instance.SetState(AppState.Logout);
            AppStateManager.Instance.ApplyState(this);
        }

        private void RefreshListBox()
        {
            listBox1.Items.Clear();

            foreach (var level in daftarLevel)
            {
                // Tampilkan ID dan nama level di listBox
                listBox1.Items.Add($"{level.IdLevel} - {level.NamaLevel}");
            }

            // Disable tombol soal sampai ada level yang dipilih
            buttonGoToQuestions.Enabled = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Aktifkan tombol jika ada item yang dipilih
            buttonGoToQuestions.Enabled = listBox1.SelectedIndex >= 0;

            int index = listBox1.SelectedIndex;

            if (index >= 0 && index < daftarLevel.Count)
            {
                selectedLevel = daftarLevel[index];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Navigasi ke tampilan soal untuk pelajar
            PelajarLevelView formPelajarLevelView = new PelajarLevelView(selectedLevel, loginData);
            formPelajarLevelView.Show();

            // Tutup form saat ini
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void labelNama_Click(object sender, EventArgs e) { }
    }
}
