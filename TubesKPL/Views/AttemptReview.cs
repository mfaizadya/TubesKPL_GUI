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
using System.Text;
using System.Text.Json;

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
            List<Attempt> listAttempts = new List<Attempt>();

            string outputPath = "data_attempt.json";
            if (File.Exists(outputPath))
            {
                string existingJson = File.ReadAllText(outputPath);
                listAttempts = JsonSerializer.Deserialize<List<Attempt>>(existingJson) ?? new List<Attempt>();
            }
            if (loginAs == "admin")
            {
                attempts = listAttempts;
            }
            else
            {
                attempts = listAttempts.Where(a => a.UserName == username).ToList();
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
