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

namespace TubesKPL
{
    public partial class MenuAdmin : Form
    {
        private LoginResponse loginData;

        public MenuAdmin(LoginResponse loginData)
        {
            InitializeComponent();
            this.loginData = loginData;

            labelNama.Text = $"Selamat datang di Logilearn, {loginData.nama}!";
        }

        // Tidak digunakan (label judul)
        private void Label1_Click(object sender, EventArgs e)
        {
        }

        // Event ketika form Admin dimuat
        private void MenuAdmin_Load(object sender, EventArgs e)
        {
        }

        // Tombol "Kelola Level dan Soal"
        private void ButtonKelolaLevel_Click(object sender, EventArgs e)
        {
            var formKelolaLevel = new KelolaLevelDanSoal(loginData);
            formKelolaLevel.Show();
            this.Hide();
        }

        // Label lain yang tidak digunakan
        private void Label2_Click(object sender, EventArgs e)
        {
        }

        // Tombol "Lihat Review Attempt"
        private void ButtonReviewAttempt_Click(object sender, EventArgs e)
        {
            var formAttemptReview = new AttemptReview("admin", loginData);
            formAttemptReview.Show();
            this.Close();
        }

        // Tombol "Logout"
        private void ButtonLogout_Click(object sender, EventArgs e)
        {
            AppStateManager.Instance.SetState(AppState.Logout);
            AppStateManager.Instance.ApplyState(this);
        }
    }
}
