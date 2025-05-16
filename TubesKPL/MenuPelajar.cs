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
        private string namaPengguna;
        public MenuPelajar(string nama)
        {
            InitializeComponent();
            namaPengguna = nama;
        }

        private void MenuPelajar_Load(object sender, EventArgs e)
        {

            labelNama.Text = $"Login berhasil, selamat datang {namaPengguna}!";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
