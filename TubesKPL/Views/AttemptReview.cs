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
    public partial class AttemptReview : Form
    {
        List<Attempt> attempts;
        string loginAs;
        LoginResponse loginData;

        public AttemptReview(string loginAs, LoginResponse loginData)
        {
            InitializeComponent();
            this.loginAs = loginAs;
            this.loginData = loginData;
            LoadAttempt(loginAs, loginData.username);
            TampilkanAttempt();
        }

        private void AttemptReview_Load(object sender, EventArgs e)
        {

        }

        private void LoadAttempt(string loginAs, string username)
        {
            var allAttempts = new List<Attempt>
            {
                new Attempt(1, "pela1", "1", 95, DateTime.Now),
                new Attempt(2, "pela2", "1", 70, DateTime.Now.AddDays(-2)),
                new Attempt(3, "pela2", "1", 50, DateTime.Now.AddDays(-2)),
            };
            if (loginAs == "admin")
            {
                attempts = allAttempts;
            }
            else
            {
                attempts = allAttempts.Where(a => a.UserName == username).ToList();
            }
        }

        private void TampilkanAttempt()
        {
            dataGridViewAttempt.DataSource = null;
            dataGridViewAttempt.DataSource = attempts;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (loginAs == "admin")
            {
                MenuAdmin formMenuAdmin = new MenuAdmin(loginData);
                formMenuAdmin.Show();
                this.Close();
            } else
            {
                MenuPelajar formMenuPelajar = new MenuPelajar(loginData);
                formMenuPelajar.Show();
                this.Close();
            }
        }
    }
}
