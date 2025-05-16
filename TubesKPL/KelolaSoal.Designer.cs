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
            SuspendLayout();
            // 
            // btnTambahSoalPG
            // 
            btnTambahSoalPG.Location = new Point(547, 97);
            btnTambahSoalPG.Name = "btnTambahSoalPG";
            btnTambahSoalPG.Size = new Size(212, 29);
            btnTambahSoalPG.TabIndex = 0;
            btnTambahSoalPG.Text = "Tambah Soal PG";
            btnTambahSoalPG.UseVisualStyleBackColor = true;
            btnTambahSoalPG.Click += btnTambahSoal_Click;
            // 
            // btnTambahSoalEssay
            // 
            btnTambahSoalEssay.Location = new Point(547, 132);
            btnTambahSoalEssay.Name = "btnTambahSoalEssay";
            btnTambahSoalEssay.Size = new Size(212, 29);
            btnTambahSoalEssay.TabIndex = 1;
            btnTambahSoalEssay.Text = "Tambah Soal Essay";
            btnTambahSoalEssay.UseVisualStyleBackColor = true;
            btnTambahSoalEssay.Click += button2_Click;
            // 
            // btnEditSoalPG
            // 
            btnEditSoalPG.Location = new Point(547, 221);
            btnEditSoalPG.Name = "btnEditSoalPG";
            btnEditSoalPG.Size = new Size(212, 29);
            btnEditSoalPG.TabIndex = 2;
            btnEditSoalPG.Text = "Edit Soal PG";
            btnEditSoalPG.UseVisualStyleBackColor = true;
            // 
            // btnEditSoalEssay
            // 
            btnEditSoalEssay.Location = new Point(547, 186);
            btnEditSoalEssay.Name = "btnEditSoalEssay";
            btnEditSoalEssay.Size = new Size(212, 29);
            btnEditSoalEssay.TabIndex = 3;
            btnEditSoalEssay.Text = "Edit Soal Essay";
            btnEditSoalEssay.UseVisualStyleBackColor = true;
            // 
            // btnHapusSoal
            // 
            btnHapusSoal.Location = new Point(547, 277);
            btnHapusSoal.Name = "btnHapusSoal";
            btnHapusSoal.Size = new Size(212, 29);
            btnHapusSoal.TabIndex = 4;
            btnHapusSoal.Text = "Hapus Soal";
            btnHapusSoal.UseVisualStyleBackColor = true;
            btnHapusSoal.Click += btnHapusSoal_Click;
            // 
            // labelPilih
            // 
            labelPilih.AutoSize = true;
            labelPilih.Location = new Point(547, 45);
            labelPilih.Name = "labelPilih";
            labelPilih.Size = new Size(156, 20);
            labelPilih.TabIndex = 6;
            labelPilih.Text = "Pilih untuk Kelola Soal";
            // 
            // labelLevel
            // 
            labelLevel.AutoSize = true;
            labelLevel.Location = new Point(547, 65);
            labelLevel.Name = "labelLevel";
            labelLevel.Size = new Size(46, 20);
            labelLevel.TabIndex = 7;
            labelLevel.Text = "Level:";
            labelLevel.Click += label1_Click;
            // 
            // labelAngkaLevel
            // 
            labelAngkaLevel.AutoSize = true;
            labelAngkaLevel.Location = new Point(599, 65);
            labelAngkaLevel.Name = "labelAngkaLevel";
            labelAngkaLevel.Size = new Size(42, 20);
            labelAngkaLevel.TabIndex = 8;
            labelAngkaLevel.Text = "label";
            // 
            // listView1
            // 
            listView1.Location = new Point(18, 21);
            listView1.Name = "listView1";
            listView1.Size = new Size(493, 417);
            listView1.TabIndex = 9;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // KelolaSoal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listView1);
            Controls.Add(labelAngkaLevel);
            Controls.Add(labelLevel);
            Controls.Add(labelPilih);
            Controls.Add(btnHapusSoal);
            Controls.Add(btnEditSoalEssay);
            Controls.Add(btnEditSoalPG);
            Controls.Add(btnTambahSoalEssay);
            Controls.Add(btnTambahSoalPG);
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
    }
}