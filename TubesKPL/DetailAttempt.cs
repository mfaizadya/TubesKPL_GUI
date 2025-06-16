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
    public partial class LoadDetail : Form
    {
        private Attempt attempt;
        public LoadDetail(Attempt attempt)
        {
            InitializeComponent();
            this.attempt = attempt;
            LoadAttemptDetail();
        }

        private void LoadAttemptDetail()
        {
            lblAttemptID.Text = $"Attempt ID: {attempt.AttemptID}";
            lblUserName.Text = $"User: {attempt.UserName}";
            lblExamID.Text = $"Exam ID: {attempt.ExamID}";
            lblScore.Text = $"Score: {attempt.Score}";
            lblDate.Text = $"Date: {attempt.AttemptDate}";
        }

        private void btnSaveEsaiScore_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Nilai esai berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
