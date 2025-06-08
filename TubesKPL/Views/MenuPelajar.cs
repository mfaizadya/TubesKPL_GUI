using AuthAPI;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TubesKPL
{

    public partial class MenuPelajar : Form
    {
        
        private List<Level> daftarLevel = new List<Level>();
        private string filePath = "data_level.json";
        LoginResponse loginData;
        Level selectedLevel;
        

        public MenuPelajar(LoginResponse loginData)
        {
            InitializeComponent();
            this.loginData = loginData;
            labelNama.Text = $"Selamat datang di Logilearn, {loginData.nama}!";
        }

        private void MenuPelajar_Load(object sender, EventArgs e)
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                daftarLevel = JsonSerializer.Deserialize<List<Level>>(json);
            }
            else
            {
                daftarLevel = new List<Level>();
            }

            RefreshListBox();
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            AppStateManager.Instance.SetState(AppState.Logout);
            AppStateManager.Instance.ApplyState(this);
        }
        private void RefreshListBox()
        {
            listBox1.Items.Clear();
            foreach (var level in daftarLevel)
            {
                listBox1.Items.Add($"{level.IdLevel} - {level.NamaLevel}");
            }
            buttonGoToQuestions.Enabled = false;
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonGoToQuestions.Enabled = listBox1.SelectedIndex >= 0;
            int index = listBox1.SelectedIndex;
            if (index >= 0 && index < daftarLevel.Count)
            {
                this.selectedLevel = daftarLevel[index];
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            PelajarLevelView formPelajarLevelView = new PelajarLevelView(selectedLevel, loginData);
            formPelajarLevelView.Show();
            this.Close();
        }

         

    }
}
