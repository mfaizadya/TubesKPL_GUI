namespace TubesKPL
{
    partial class LoadDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblUserName = new Label();
            lblExamID = new Label();
            lblScore = new Label();
            lblDate = new Label();
            groupBox1 = new GroupBox();
            lstPilihanGandaJawaban = new ListBox();
            groupBox2 = new GroupBox();
            txtJawabanEsai = new TextBox();
            label1 = new Label();
            txtEsaiScore = new TextBox();
            btnSaveEsaiScore = new Button();
            btnBack = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(18, 59);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(33, 15);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "User:";
            // 
            // lblExamID
            // 
            lblExamID.AutoSize = true;
            lblExamID.Location = new Point(18, 82);
            lblExamID.Name = "lblExamID";
            lblExamID.Size = new Size(52, 15);
            lblExamID.TabIndex = 2;
            lblExamID.Text = "Ezam ID:";
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Location = new Point(18, 106);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(39, 15);
            lblScore.TabIndex = 3;
            lblScore.Text = "Score:";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(17, 133);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(81, 15);
            lblDate.TabIndex = 4;
            lblDate.Text = "Attempt Date:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lstPilihanGandaJawaban);
            groupBox1.Location = new Point(17, 166);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(404, 161);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Jawaban Pilihan Ganda:";
            // 
            // lstPilihanGandaJawaban
            // 
            lstPilihanGandaJawaban.FormattingEnabled = true;
            lstPilihanGandaJawaban.ItemHeight = 15;
            lstPilihanGandaJawaban.Location = new Point(11, 23);
            lstPilihanGandaJawaban.Name = "lstPilihanGandaJawaban";
            lstPilihanGandaJawaban.Size = new Size(273, 124);
            lstPilihanGandaJawaban.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtJawabanEsai);
            groupBox2.Location = new Point(18, 343);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(403, 117);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Jawaban Esai:";
            // 
            // txtJawabanEsai
            // 
            txtJawabanEsai.Location = new Point(10, 22);
            txtJawabanEsai.Multiline = true;
            txtJawabanEsai.Name = "txtJawabanEsai";
            txtJawabanEsai.Size = new Size(273, 81);
            txtJawabanEsai.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 470);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 7;
            label1.Text = "Nilai Esai:";
            // 
            // txtEsaiScore
            // 
            txtEsaiScore.Location = new Point(81, 466);
            txtEsaiScore.Name = "txtEsaiScore";
            txtEsaiScore.Size = new Size(57, 23);
            txtEsaiScore.TabIndex = 8;
            // 
            // btnSaveEsaiScore
            // 
            btnSaveEsaiScore.Location = new Point(155, 466);
            btnSaveEsaiScore.Name = "btnSaveEsaiScore";
            btnSaveEsaiScore.Size = new Size(75, 23);
            btnSaveEsaiScore.TabIndex = 9;
            btnSaveEsaiScore.Text = "Simpan";
            btnSaveEsaiScore.UseVisualStyleBackColor = true;
            btnSaveEsaiScore.Click += btnSaveEsaiScore_Click_1;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(346, 525);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 10;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // LoadDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 597);
            Controls.Add(btnBack);
            Controls.Add(btnSaveEsaiScore);
            Controls.Add(txtEsaiScore);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lblDate);
            Controls.Add(lblScore);
            Controls.Add(lblExamID);
            Controls.Add(lblUserName);
            Name = "LoadDetail";
            Text = "DetailAttempt";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblUserName;
        private Label lblExamID;
        private Label lblScore;
        private Label lblDate;
        private GroupBox groupBox1;
        private ListBox lstPilihanGandaJawaban;
        private GroupBox groupBox2;
        private TextBox txtJawabanEsai;
        private Label label1;
        private TextBox txtEsaiScore;
        private Button btnSaveEsaiScore;
        private Button btnBack;
    }
}