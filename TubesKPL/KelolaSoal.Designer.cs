namespace TubesKPL
{
    partial class KelolaSoal
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
            btnTambahSoalPG = new Button();
            btnTambahSoalEssay = new Button();
            btnEditSoalPG = new Button();
            btnEditSoalEssay = new Button();
            btnHapusSoalPG = new Button();
            btnHapusSoalEssay = new Button();
            labelPilih = new Label();
            SuspendLayout();
            // 
            // btnTambahSoalPG
            // 
            btnTambahSoalPG.Location = new Point(67, 209);
            btnTambahSoalPG.Name = "btnTambahSoalPG";
            btnTambahSoalPG.Size = new Size(212, 29);
            btnTambahSoalPG.TabIndex = 0;
            btnTambahSoalPG.Text = "Tambah Soal PG";
            btnTambahSoalPG.UseVisualStyleBackColor = true;
            btnTambahSoalPG.Click += btnTambahSoal_Click;
            // 
            // btnTambahSoalEssay
            // 
            btnTambahSoalEssay.Location = new Point(67, 244);
            btnTambahSoalEssay.Name = "btnTambahSoalEssay";
            btnTambahSoalEssay.Size = new Size(212, 29);
            btnTambahSoalEssay.TabIndex = 1;
            btnTambahSoalEssay.Text = "Tambah Soal Essay";
            btnTambahSoalEssay.UseVisualStyleBackColor = true;
            btnTambahSoalEssay.Click += button2_Click;
            // 
            // btnEditSoalPG
            // 
            btnEditSoalPG.Location = new Point(285, 209);
            btnEditSoalPG.Name = "btnEditSoalPG";
            btnEditSoalPG.Size = new Size(212, 29);
            btnEditSoalPG.TabIndex = 2;
            btnEditSoalPG.Text = "Edit Soal PG";
            btnEditSoalPG.UseVisualStyleBackColor = true;
            // 
            // btnEditSoalEssay
            // 
            btnEditSoalEssay.Location = new Point(285, 244);
            btnEditSoalEssay.Name = "btnEditSoalEssay";
            btnEditSoalEssay.Size = new Size(212, 29);
            btnEditSoalEssay.TabIndex = 3;
            btnEditSoalEssay.Text = "Edit Soal Essay";
            btnEditSoalEssay.UseVisualStyleBackColor = true;
            // 
            // btnHapusSoalPG
            // 
            btnHapusSoalPG.Location = new Point(503, 209);
            btnHapusSoalPG.Name = "btnHapusSoalPG";
            btnHapusSoalPG.Size = new Size(212, 29);
            btnHapusSoalPG.TabIndex = 4;
            btnHapusSoalPG.Text = "Hapus Soal PG";
            btnHapusSoalPG.UseVisualStyleBackColor = true;
            // 
            // btnHapusSoalEssay
            // 
            btnHapusSoalEssay.Location = new Point(503, 244);
            btnHapusSoalEssay.Name = "btnHapusSoalEssay";
            btnHapusSoalEssay.Size = new Size(212, 29);
            btnHapusSoalEssay.TabIndex = 5;
            btnHapusSoalEssay.Text = "Hapus Soal Essay";
            btnHapusSoalEssay.UseVisualStyleBackColor = true;
            btnHapusSoalEssay.Click += btnHapusSoalEssay_Click;
            // 
            // labelPilih
            // 
            labelPilih.AutoSize = true;
            labelPilih.Location = new Point(312, 144);
            labelPilih.Name = "labelPilih";
            labelPilih.Size = new Size(156, 20);
            labelPilih.TabIndex = 6;
            labelPilih.Text = "Pilih untuk Kelola Soal";
            // 
            // KelolaSoal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelPilih);
            Controls.Add(btnHapusSoalEssay);
            Controls.Add(btnHapusSoalPG);
            Controls.Add(btnEditSoalEssay);
            Controls.Add(btnEditSoalPG);
            Controls.Add(btnTambahSoalEssay);
            Controls.Add(btnTambahSoalPG);
            Name = "KelolaSoal";
            Text = "KelolaSoal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTambahSoalPG;
        private Button btnTambahSoalEssay;
        private Button btnEditSoalPG;
        private Button btnEditSoalEssay;
        private Button btnHapusSoalPG;
        private Button btnHapusSoalEssay;
        private Label labelPilih;
    }
}