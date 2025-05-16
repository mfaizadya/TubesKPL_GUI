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

namespace TubesKPL
{
    public partial class MenuPelajar : Form
    {
        LoginResponse loginData;
        public MenuPelajar(LoginResponse loginData)
        {
            InitializeComponent();
            this.loginData = loginData;
            labelNama.Text = $"Selamat datang di Logilearn, {loginData.nama}!";
        }

        private void MenuPelajar_Load(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelNama_Click(object sender, EventArgs e)
        {

        }

        private void buttonReviewAttempt_Click(object sender, EventArgs e)
        {
            AttemptReview formAttemptReview = new AttemptReview("pelajar", loginData);
            formAttemptReview.Show();
            this.Close();
        }
    }
}
