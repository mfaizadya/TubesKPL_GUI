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
using TubesKPL.Views;

namespace TubesKPL
{
    public partial class AttemptReview : Form
    {
        List<Attempt> attempts;
        string loginAs;
        LoginResponse loginData;

        /// <summary>
        /// Konstruktor untuk class AttemptReview.
        /// </summary>
        public AttemptReview(string loginAs, LoginResponse loginData)
        {
            InitializeComponent();
            this.loginAs = loginAs;
            this.loginData = loginData;

            try
            {
                LoadAttempt(loginAs, loginData.username);
                TampilkanAttempt();
            } catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan saat memuat data attempt: {ex.Message}",
                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void AttemptReview_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Method yang digunakan untuk membaca file JSON yang ada pada dataPath kemudian melakukan deserialisasi menjadi List Attempt pada variable attempts.
        /// </summary>
        private void LoadAttempt(string loginAs, string username)
        {
            List<Attempt> listAttempts = new List<Attempt>();
            string dataPath = "data_attempt.json";

            try
            {
                if (File.Exists(dataPath))
                {
                    string existingJson = File.ReadAllText(dataPath);
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
            } catch (JsonException je)
            {
                MessageBox.Show($"Format data JSON tidak valid: {je.Message}",
                    "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } catch (IOException ie)
            {
                MessageBox.Show($"Kesalahan saat membaca file: {ie.Message}",
                    "IO Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        /// <summary>
        /// Method untuk menampilkan List Attempt yang sudah di-load, jika tidak ada data Attempt maka tidak menampilkan data apapun pada data grid.
        /// </summary>
        private void TampilkanAttempt()
        {
            dataGridViewAttempt.DataSource = null;
            dataGridViewAttempt.DataSource = attempts;
        }

        /// <summary>
        /// Method yang dijalankan ketika button back ditekan, mengarahkan pengguna ke menu berdasarkan role nya.
        /// </summary>
        private void ButtonBack_Click(object sender, EventArgs e)
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

        private void ButtonDetail_Click(object sender, EventArgs e)
        {
            
            if (dataGridViewAttempt.SelectedRows.Count > 0)
            {
                Attempt selectedAttempt = dataGridViewAttempt.SelectedRows[0].DataBoundItem as Attempt;

                if (selectedAttempt != null)
                {
                    if (loginAs == "admin")
                    {
                        AttemptDetailForm formDetail = new AttemptDetailForm(selectedAttempt, loginData);
                        formDetail.ShowDialog();

                        // refresh setelah kembali (bila ada perubahan)
                        LoadAttempt(loginAs, loginData.username);
                        TampilkanAttempt();
                    }
                    else
                    {
                        AttemptDetailPelajar formDetail = new AttemptDetailPelajar(selectedAttempt, loginData);
                        formDetail.ShowDialog();

                        // refresh setelah kembali (bila ada perubahan)
                        LoadAttempt(loginAs, loginData.username);
                        TampilkanAttempt();
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("Pilih salah satu data attempt!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
