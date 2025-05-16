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
using AuthAPI;

namespace TubesKPL
{
    public partial class LoginAdmin : Form
    {
        public LoginAdmin()
        {
            InitializeComponent();
        }

        private async void buttonLoginAdmin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            var loginReq = new AuthAPI.LoginReq { Username = username, Password = password };

            var loginResp = await LoginHelper.SendLoginRequest(loginReq, "admin");

            try
            {
                LoginResponse loginData = JsonSerializer.Deserialize<LoginResponse>(loginResp);

                if (loginData != null && !string.IsNullOrEmpty(loginData.nama))
                {
                    labelOutput.Text = $"Login berhasil, selamat datang {loginData.nama}!";
                    MenuAdmin formMenuAdmin = new MenuAdmin(loginData);
                    formMenuAdmin.Show();
                    this.Close();
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

        private void buttonLoginPelajar_Click(object sender, EventArgs e)
        {
            LoginPelajar formLoginPelajar = new LoginPelajar();
            formLoginPelajar.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LoginAdmin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
