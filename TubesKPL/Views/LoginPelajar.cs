using AuthAPI;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TubesKPL
{
    public partial class LoginPelajar : Form
    {
        public LoginPelajar()
        {
            InitializeComponent(); // Inisialisasi komponen GUI
        }

        private void LoginPelajar_Load(object sender, EventArgs e)
        {
            // Event ketika form LoginPelajar pertama kali dimuat
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            // Buat request login
            var loginReq = new AuthAPI.LoginReq
            {
                Username = username,
                Password = password
            };

            // Kirim request ke API untuk role "pelajar"
            var loginResp = await LoginHelper.SendLoginRequest(loginReq, "pelajar");

            try
            {
                // Deserialize response menjadi objek LoginResponse
                LoginResponse loginData = JsonSerializer.Deserialize<LoginResponse>(loginResp);

                // Jika berhasil login dan data nama tersedia
                if (loginData != null && !string.IsNullOrEmpty(loginData.nama))
                {
                    labelOutput.Text = $"Login berhasil, selamat datang {loginData.nama}!";

                    // Arahkan ke MenuPelajar setelah login berhasil
                    MenuPelajar menuForm = new MenuPelajar(loginData);
                    menuForm.Show();
                    this.Hide(); // Sembunyikan form login
                }
                else
                {
                    // Data login tidak valid
                    labelOutput.Text = $"Login gagal, data kosong.";
                }
            }
            catch (JsonException)
            {
                // Tangani error jika deserialisasi gagal (response bukan JSON valid)
                labelOutput.Text = $"Login gagal, {loginResp}";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginAdmin formLoginAdmin = new LoginAdmin();
            formLoginAdmin.Show();
            this.Hide(); // Sembunyikan form login pelajar
        }

        private void buttonSignUpPelajar_Click(object sender, EventArgs e)
        {
            SignUpPelajar formSignUpPelajar = new SignUpPelajar();
            formSignUpPelajar.Show();
            this.Hide(); // Sembunyikan form login pelajar
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Tidak ada logika tambahan saat ini
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Placeholder untuk aksi klik label1 (jika diperlukan)
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Placeholder untuk aksi klik label2 (jika diperlukan)
        }

        private void label4_Click(object sender, EventArgs e)
        {
            // Placeholder untuk aksi klik label4 (jika diperlukan)
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            // Tidak ada logika tambahan saat ini
        }
    }
}
