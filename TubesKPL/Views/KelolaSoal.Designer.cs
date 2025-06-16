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
            btnHapusSoal = new Button();
            labelPilih = new Label();
            labelLevel = new Label();
            labelAngkaLevel = new Label();
            listView1 = new ListView();
            buttonBack = new Button();
            SuspendLayout();
            // 
            // btnTambahSoalPG
            // 
            btnTambahSoalPG.Location = new Point(889, 155);
            btnTambahSoalPG.Margin = new Padding(5, 5, 5, 5);
            btnTambahSoalPG.Name = "btnTambahSoalPG";
            btnTambahSoalPG.Size = new Size(344, 46);
            btnTambahSoalPG.TabIndex = 0;
            btnTambahSoalPG.Text = "Tambah Soal PG";
            btnTambahSoalPG.UseVisualStyleBackColor = true;
            btnTambahSoalPG.Click += btnTambahSoal_Click;
            // 
            // btnTambahSoalEssay
            // 
            btnTambahSoalEssay.Location = new Point(889, 211);
            btnTambahSoalEssay.Margin = new Padding(5, 5, 5, 5);
            btnTambahSoalEssay.Name = "btnTambahSoalEssay";
            btnTambahSoalEssay.Size = new Size(344, 46);
            btnTambahSoalEssay.TabIndex = 1;
            btnTambahSoalEssay.Text = "Tambah Soal Esai";
            btnTambahSoalEssay.UseVisualStyleBackColor = true;
            btnTambahSoalEssay.Click += button2_Click;
            // 
            // btnEditSoalPG
            // 
            btnEditSoalPG.Location = new Point(889, 354);
            btnEditSoalPG.Margin = new Padding(5, 5, 5, 5);
            btnEditSoalPG.Name = "btnEditSoalPG";
            btnEditSoalPG.Size = new Size(344, 46);
            btnEditSoalPG.TabIndex = 2;
            btnEditSoalPG.Text = "Edit Soal PG";
            btnEditSoalPG.UseVisualStyleBackColor = true;
            btnEditSoalPG.Click += btnEditSoalPG_Click;
            // 
            // btnEditSoalEssay
            // 
            btnEditSoalEssay.Location = new Point(889, 298);
            btnEditSoalEssay.Margin = new Padding(5, 5, 5, 5);
            btnEditSoalEssay.Name = "btnEditSoalEssay";
            btnEditSoalEssay.Size = new Size(344, 46);
            btnEditSoalEssay.TabIndex = 3;
            btnEditSoalEssay.Text = "Edit Soal Esai";
            btnEditSoalEssay.UseVisualStyleBackColor = true;
            btnEditSoalEssay.Click += btnEditSoalEssay_Click;
            // 
            // btnHapusSoal
            // 
            btnHapusSoal.Location = new Point(889, 443);
            btnHapusSoal.Margin = new Padding(5, 5, 5, 5);
            btnHapusSoal.Name = "btnHapusSoal";
            btnHapusSoal.Size = new Size(344, 46);
            btnHapusSoal.TabIndex = 4;
            btnHapusSoal.Text = "Hapus Soal";
            btnHapusSoal.UseVisualStyleBackColor = true;
            btnHapusSoal.Click += btnHapusSoal_Click;
            // 
            // labelPilih
            // 
            labelPilih.AutoSize = true;
            labelPilih.Location = new Point(889, 72);
            labelPilih.Margin = new Padding(5, 0, 5, 0);
            labelPilih.Name = "labelPilih";
            labelPilih.Size = new Size(252, 32);
            labelPilih.TabIndex = 6;
            labelPilih.Text = "Pilih untuk Kelola Soal";
            // 
            // labelLevel
            // 
            labelLevel.AutoSize = true;
            labelLevel.Location = new Point(889, 104);
            labelLevel.Margin = new Padding(5, 0, 5, 0);
            labelLevel.Name = "labelLevel";
            labelLevel.Size = new Size(74, 32);
            labelLevel.TabIndex = 7;
            labelLevel.Text = "Level:";
            labelLevel.Click += label1_Click;
            // 
            // labelAngkaLevel
            // 
            labelAngkaLevel.AutoSize = true;
            labelAngkaLevel.Location = new Point(973, 104);
            labelAngkaLevel.Margin = new Padding(5, 0, 5, 0);
            labelAngkaLevel.Name = "labelAngkaLevel";
            labelAngkaLevel.Size = new Size(65, 32);
            labelAngkaLevel.TabIndex = 8;
            labelAngkaLevel.Text = "label";
            // 
            // listView1
            // 
            listView1.Location = new Point(29, 34);
            listView1.Margin = new Padding(5, 5, 5, 5);
            listView1.Name = "listView1";
            listView1.Size = new Size(799, 665);
            listView1.TabIndex = 9;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(1100, 654);
            buttonBack.Margin = new Padding(5, 5, 5, 5);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(133, 46);
            buttonBack.TabIndex = 10;
            buttonBack.Text = "Kembali";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += button1_Click;
            // 
            // KelolaSoal
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 720);
            Controls.Add(buttonBack);
            Controls.Add(listView1);
            Controls.Add(labelAngkaLevel);
            Controls.Add(labelLevel);
            Controls.Add(labelPilih);
            Controls.Add(btnHapusSoal);
            Controls.Add(btnEditSoalEssay);
            Controls.Add(btnEditSoalPG);
            Controls.Add(btnTambahSoalEssay);
            Controls.Add(btnTambahSoalPG);
            Margin = new Padding(5, 5, 5, 5);
            Name = "KelolaSoal";
            Text = "KelolaSoal";
            Load += KelolaSoal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTambahSoalPG;
        private Button btnTambahSoalEssay;
        private Button btnEditSoalPG;
        private Button btnEditSoalEssay;
        private Button btnHapusSoal;
        private Label labelPilih;
        private Label labelLevel;
        private Label labelAngkaLevel;
        private ListView listView1;
        private Button buttonBack;
    }
}