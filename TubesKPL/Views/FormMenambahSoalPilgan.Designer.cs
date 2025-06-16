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
            txtSoal.Location = new Point(78, 88);
            txtSoal.Margin = new Padding(5, 6, 5, 6);
            txtSoal.Multiline = true;
            txtSoal.Name = "txtSoal";
            txtSoal.Size = new Size(919, 87);
            txtSoal.TabIndex = 0;
            txtSoal.TextChanged += txtSoal_TextChanged;
            // 
            // txtOption
            // 
            txtOption.Location = new Point(75, 218);
            txtOption.Margin = new Padding(5, 6, 5, 6);
            txtOption.Name = "txtOption";
            txtOption.Size = new Size(560, 39);
            txtOption.TabIndex = 1;
            txtOption.TextChanged += txtOption_TextChanged;
            // 
            // btnAddOption
            // 
            btnAddOption.Location = new Point(679, 215);
            btnAddOption.Margin = new Padding(5, 6, 5, 6);
            btnAddOption.Name = "btnAddOption";
            btnAddOption.Size = new Size(145, 45);
            btnAddOption.TabIndex = 2;
            btnAddOption.Text = "Masukkan";
            btnAddOption.UseVisualStyleBackColor = true;
            btnAddOption.Click += btnAddOption_Click;
            // 
            // lstOptions
            // 
            lstOptions.FormattingEnabled = true;
            lstOptions.Location = new Point(76, 309);
            lstOptions.Margin = new Padding(5, 6, 5, 6);
            lstOptions.Name = "lstOptions";
            lstOptions.Size = new Size(787, 324);
            lstOptions.TabIndex = 3;
            lstOptions.SelectedIndexChanged += lstOptions_SelectedIndexChanged;
            // 
            // txtJawaban
            // 
            txtJawaban.Location = new Point(78, 712);
            txtJawaban.Margin = new Padding(5, 6, 5, 6);
            txtJawaban.Name = "txtJawaban";
            txtJawaban.Size = new Size(802, 39);
            txtJawaban.TabIndex = 4;
            txtJawaban.TextChanged += txtJawaban_TextChanged;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(848, 838);
            btnSimpan.Margin = new Padding(5, 6, 5, 6);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(153, 46);
            btnSimpan.TabIndex = 5;
            btnSimpan.Text = "Selesai";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // Pertanyaan
            // 
            Pertanyaan.AutoSize = true;
            Pertanyaan.Location = new Point(78, 50);
            Pertanyaan.Margin = new Padding(5, 0, 5, 0);
            Pertanyaan.Name = "Pertanyaan";
            Pertanyaan.Size = new Size(143, 32);
            Pertanyaan.TabIndex = 6;
            Pertanyaan.Text = "Pertanyaan :";
            // 
            // TambahOpsi
            // 
            TambahOpsi.AutoSize = true;
            TambahOpsi.Location = new Point(75, 184);
            TambahOpsi.Margin = new Padding(5, 0, 5, 0);
            TambahOpsi.Name = "TambahOpsi";
            TambahOpsi.Size = new Size(74, 32);
            TambahOpsi.TabIndex = 7;
            TambahOpsi.Text = "Opsi :";
            // 
            // Jawaban
            // 
            Jawaban.AutoSize = true;
            Jawaban.Location = new Point(78, 674);
            Jawaban.Margin = new Padding(5, 0, 5, 0);
            Jawaban.Name = "Jawaban";
            Jawaban.Size = new Size(230, 32);
            Jawaban.TabIndex = 8;
            Jawaban.Text = "Jawaban Yang Benar";
            
            // 
            // FormMenambahSoalPilgan
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1485, 960);
            Controls.Add(Jawaban);
            Controls.Add(TambahOpsi);
            Controls.Add(Pertanyaan);
            Controls.Add(btnSimpan);
            Controls.Add(txtJawaban);
            Controls.Add(lstOptions);
            Controls.Add(btnAddOption);
            Controls.Add(txtOption);
            Controls.Add(txtSoal);
            Margin = new Padding(5, 6, 5, 6);
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