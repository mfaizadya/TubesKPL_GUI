using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AuthAPI;
using static TubesKPL.MenuPelajar;

namespace TubesKPL
{
    public partial class MenuAdmin : Form
    {
        LoginResponse loginData;
        

        public MenuAdmin(LoginResponse loginData)
        {
            InitializeComponent();
            this.loginData = loginData;
            labelNama.Text = $"Selamat datang di Logilearn, {loginData.nama}!";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AppStateManager.Instance.SetState(AppState.Logout);
            AppStateManager.Instance.ApplyState(this);
        }

        private void MenuAdmin_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kelola_Level_dan_Soal formkelolalv = new Kelola_Level_dan_Soal(loginData);
            formkelolalv.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            AttemptReview formAttemptReview = new AttemptReview("admin",loginData);
            formAttemptReview.Show();
            this.Close();
        }

       
    }


}
