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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using AuthAPI;

namespace TubesKPL
{
    public partial class LoginPelajar : Form
    {
        public LoginPelajar()
        {
            InitializeComponent();
        }

        private void LoginPelajar_Load(object sender, EventArgs e)
        {

        }

        private async void button3_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            var loginReq = new AuthAPI.LoginReq { Username = username, Password = password };

            var loginResp = await LoginHelper.SendLoginRequest(loginReq, "pelajar");

            try
            {
                LoginResponse loginData = JsonSerializer.Deserialize<LoginResponse>(loginResp);

                if (loginData != null && !string.IsNullOrEmpty(loginData.nama))
                {
                    labelOutput.Text = $"Login berhasil, selamat datang {loginData.nama}!";
                    MenuPelajar menuForm = new MenuPelajar(loginData);
                    menuForm.Show();
                    this.Hide();
                }
                else
                {
                    labelOutput.Text = $"Login gagal, data kosong.";
                }
            }
            catch (JsonException)
            {
                labelOutput.Text = $"Login gagal, {loginResp}";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginAdmin formLoginAdmin = new LoginAdmin();
            formLoginAdmin.Show();
            this.Hide();
        }

        private void buttonSignUpPelajar_Click(object sender, EventArgs e)
        {
            SignUpPelajar formSignUpPelajar = new SignUpPelajar();
            formSignUpPelajar.Show();
            this.Hide();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
