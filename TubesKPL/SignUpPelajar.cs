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

namespace TubesKPL
{
    public partial class SignUpPelajar : Form
    {
        public SignUpPelajar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SignUpPelajar_Load(object sender, EventArgs e)
        {

        }

        private void textBoxNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private async void buttonSignUpPelajar_Click(object sender, EventArgs e)
        {
            string nama = textBoxNama.Text.Trim();
            string username = textBoxUsername.Text.Trim();
            string password = textBoxPassword.Text.Trim();

            if (string.IsNullOrEmpty(nama) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                labelOutput.Text = "Semua field harus diisi.";
                return;
            }

            var pelajarBaru = new
            {
                nama = nama,
                username = username,
                password = password
            };

            var httpClient = new HttpClient();
            var json = JsonSerializer.Serialize(pelajarBaru);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                var response = await httpClient.PostAsync("http://localhost:5101/api/pelajar/register", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Registrasi berhasil! Silakan login.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoginPelajar loginForm = new LoginPelajar();
                    loginForm.Show();
                    this.Close();
                }
                else
                {
                    string errorResponse = await response.Content.ReadAsStringAsync();
                    labelOutput.Text = $"Registrasi gagal: {errorResponse}";
                }
            }
            catch (Exception ex)
            {
                labelOutput.Text = $"Terjadi kesalahan: {ex.Message}";
            }
        }


        private void buttonLoginPelajar_Click(object sender, EventArgs e)
        {
            LoginPelajar formLoginPelajar = new LoginPelajar();
            formLoginPelajar.Show();
            this.Close();
        }

        private void buttonLoginAdmin_Click(object sender, EventArgs e)
        {
            LoginAdmin formLoginAdmin = new LoginAdmin();
            formLoginAdmin.Show();
            this.Close();
        }
    }
}
