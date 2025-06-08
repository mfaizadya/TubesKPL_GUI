namespace TubesKPL
{
    partial class FormMenambahSoalPilgan
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
            txtSoal = new TextBox();
            txtOption = new TextBox();
            btnAddOption = new Button();
            lstOptions = new ListBox();
            txtJawaban = new TextBox();
            btnSimpan = new Button();
            Pertanyaan = new Label();
            TambahOpsi = new Label();
            Jawaban = new Label();
            SuspendLayout();
            // 
            // txtSoal
            // 
            txtSoal.Location = new Point(48, 55);
            txtSoal.Margin = new Padding(3, 4, 3, 4);
            txtSoal.Multiline = true;
            txtSoal.Name = "txtSoal";
            txtSoal.Size = new Size(567, 56);
            txtSoal.TabIndex = 0;
            txtSoal.TextChanged += txtSoal_TextChanged;
            // 
            // txtOption
            // 
            txtOption.Location = new Point(46, 136);
            txtOption.Margin = new Padding(3, 4, 3, 4);
            txtOption.Name = "txtOption";
            txtOption.Size = new Size(346, 27);
            txtOption.TabIndex = 1;
            txtOption.TextChanged += txtOption_TextChanged;
            // 
            // btnAddOption
            // 
            btnAddOption.Location = new Point(418, 139);
            btnAddOption.Margin = new Padding(3, 4, 3, 4);
            btnAddOption.Name = "btnAddOption";
            btnAddOption.Size = new Size(63, 28);
            btnAddOption.TabIndex = 2;
            btnAddOption.Text = "input";
            btnAddOption.UseVisualStyleBackColor = true;
            btnAddOption.Click += btnAddOption_Click;
            // 
            // lstOptions
            // 
            lstOptions.FormattingEnabled = true;
            lstOptions.Location = new Point(47, 193);
            lstOptions.Margin = new Padding(3, 4, 3, 4);
            lstOptions.Name = "lstOptions";
            lstOptions.Size = new Size(486, 204);
            lstOptions.TabIndex = 3;
            lstOptions.SelectedIndexChanged += lstOptions_SelectedIndexChanged;
            // 
            // txtJawaban
            // 
            txtJawaban.Location = new Point(48, 445);
            txtJawaban.Margin = new Padding(3, 4, 3, 4);
            txtJawaban.Name = "txtJawaban";
            txtJawaban.Size = new Size(495, 27);
            txtJawaban.TabIndex = 4;
            txtJawaban.TextChanged += txtJawaban_TextChanged;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(522, 524);
            btnSimpan.Margin = new Padding(3, 4, 3, 4);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(94, 29);
            btnSimpan.TabIndex = 5;
            btnSimpan.Text = "Selesai";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // Pertanyaan
            // 
            Pertanyaan.AutoSize = true;
            Pertanyaan.Location = new Point(48, 31);
            Pertanyaan.Name = "Pertanyaan";
            Pertanyaan.Size = new Size(88, 20);
            Pertanyaan.TabIndex = 6;
            Pertanyaan.Text = "Pertanyaan :";
            // 
            // TambahOpsi
            // 
            TambahOpsi.AutoSize = true;
            TambahOpsi.Location = new Point(46, 115);
            TambahOpsi.Name = "TambahOpsi";
            TambahOpsi.Size = new Size(46, 20);
            TambahOpsi.TabIndex = 7;
            TambahOpsi.Text = "Opsi :";
            // 
            // Jawaban
            // 
            Jawaban.AutoSize = true;
            Jawaban.Location = new Point(48, 421);
            Jawaban.Name = "Jawaban";
            Jawaban.Size = new Size(144, 20);
            Jawaban.TabIndex = 8;
            Jawaban.Text = "Jawaban Yang Benar";
            // 
            // FormMenambahSoalPilgan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(Jawaban);
            Controls.Add(TambahOpsi);
            Controls.Add(Pertanyaan);
            Controls.Add(btnSimpan);
            Controls.Add(txtJawaban);
            Controls.Add(lstOptions);
            Controls.Add(btnAddOption);
            Controls.Add(txtOption);
            Controls.Add(txtSoal);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMenambahSoalPilgan";
            Text = "MenambahSoalPilgan";
            Load += MenambahSoalPilgan_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSoal;
        private TextBox txtOption;
        private Button btnAddOption;
        private ListBox lstOptions;
        private TextBox txtJawaban;
        private Button btnSimpan;
        private Label Pertanyaan;
        private Label TambahOpsi;
        private Label Jawaban;
    }
}