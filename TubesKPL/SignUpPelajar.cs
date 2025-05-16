using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        private void buttonSignUpPelajar_Click(object sender, EventArgs e)
        {

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
