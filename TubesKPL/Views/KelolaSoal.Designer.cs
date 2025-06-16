namespace TubesKPL
{
    partial class KelolaSoal
    {
        /// <summary>
        /// Komponen yang dibutuhkan oleh desain form.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Membersihkan resource yang sedang digunakan.
        /// </summary>
        /// <param name="disposing">true jika resource harus dibersihkan; false jika tidak.</param>
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
        /// Metode inisialisasi komponen UI yang diperlukan.
        /// Jangan ubah langsung isi metode ini menggunakan code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnTambahSoalPG = new Button();
            btnTambahSoalEssay = new Button();
            btnEditSoalPG = new Button();
            btnEditSoalEssay = new Button();
            btnHapusSoal = new Button();
            lblPilihAksi = new Label();
            listSoal = new ListView();
            btnKembali = new Button();
            SuspendLayout();
            // 
            // btnTambahSoalPG
            // 
            btnTambahSoalPG.Location = new Point(479, 73);
            btnTambahSoalPG.Margin = new Padding(3, 2, 3, 2);
            btnTambahSoalPG.Name = "btnTambahSoalPG";
            btnTambahSoalPG.Size = new Size(185, 22);
            btnTambahSoalPG.TabIndex = 0;
            btnTambahSoalPG.Text = "Tambah Soal PG";
            btnTambahSoalPG.UseVisualStyleBackColor = true;
            btnTambahSoalPG.Click += BtnTambahSoalPG_Click;
            // 
            // btnTambahSoalEssay
            // 
            btnTambahSoalEssay.Location = new Point(479, 99);
            btnTambahSoalEssay.Margin = new Padding(3, 2, 3, 2);
            btnTambahSoalEssay.Name = "btnTambahSoalEssay";
            btnTambahSoalEssay.Size = new Size(185, 22);
            btnTambahSoalEssay.TabIndex = 1;
            btnTambahSoalEssay.Text = "Tambah Soal Esai";
            btnTambahSoalEssay.UseVisualStyleBackColor = true;
            btnTambahSoalEssay.Click += BtnTambahSoalEssay_Click;
            // 
            // btnEditSoalPG
            // 
            btnEditSoalPG.Location = new Point(479, 166);
            btnEditSoalPG.Margin = new Padding(3, 2, 3, 2);
            btnEditSoalPG.Name = "btnEditSoalPG";
            btnEditSoalPG.Size = new Size(185, 22);
            btnEditSoalPG.TabIndex = 2;
            btnEditSoalPG.Text = "Edit Soal PG";
            btnEditSoalPG.UseVisualStyleBackColor = true;
            btnEditSoalPG.Click += BtnEditSoalPG_Click;
            // 
            // btnEditSoalEssay
            // 
            btnEditSoalEssay.Location = new Point(479, 140);
            btnEditSoalEssay.Margin = new Padding(3, 2, 3, 2);
            btnEditSoalEssay.Name = "btnEditSoalEssay";
            btnEditSoalEssay.Size = new Size(185, 22);
            btnEditSoalEssay.TabIndex = 3;
            btnEditSoalEssay.Text = "Edit Soal Esai";
            btnEditSoalEssay.UseVisualStyleBackColor = true;
            btnEditSoalEssay.Click += BtnEditSoalEssay_Click;
            // 
            // btnHapusSoal
            // 
            btnHapusSoal.Location = new Point(479, 208);
            btnHapusSoal.Margin = new Padding(3, 2, 3, 2);
            btnHapusSoal.Name = "btnHapusSoal";
            btnHapusSoal.Size = new Size(185, 22);
            btnHapusSoal.TabIndex = 4;
            btnHapusSoal.Text = "Hapus Soal";
            btnHapusSoal.UseVisualStyleBackColor = true;
            btnHapusSoal.Click += BtnHapusSoal_Click;
            // 
            // lblPilihAksi
            // 
            lblPilihAksi.AutoSize = true;
            lblPilihAksi.Location = new Point(479, 34);
            lblPilihAksi.Name = "lblPilihAksi";
            lblPilihAksi.Size = new Size(124, 15);
            lblPilihAksi.TabIndex = 6;
            lblPilihAksi.Text = "Pilih untuk Kelola Soal";
            // 
            // listSoal
            // 
            listSoal.Location = new Point(16, 16);
            listSoal.Margin = new Padding(3, 2, 3, 2);
            listSoal.Name = "listSoal";
            listSoal.Size = new Size(432, 314);
            listSoal.TabIndex = 9;
            listSoal.UseCompatibleStateImageBehavior = false;
            listSoal.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // btnKembali
            // 
            btnKembali.Location = new Point(592, 307);
            btnKembali.Margin = new Padding(3, 2, 3, 2);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(72, 22);
            btnKembali.TabIndex = 10;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = true;
            btnKembali.Click += BtnKembali_Click;
            // 
            // KelolaSoal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(btnKembali);
            Controls.Add(listSoal);
            Controls.Add(lblPilihAksi);
            Controls.Add(btnHapusSoal);
            Controls.Add(btnEditSoalEssay);
            Controls.Add(btnEditSoalPG);
            Controls.Add(btnTambahSoalEssay);
            Controls.Add(btnTambahSoalPG);
            Margin = new Padding(3, 2, 3, 2);
            Name = "KelolaSoal";
            Text = "Kelola Soal";
            Load += KelolaSoal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        // Deklarasi komponen UI
        private Button btnTambahSoalPG;
        private Button btnTambahSoalEssay;
        private Button btnEditSoalPG;
        private Button btnEditSoalEssay;
        private Button btnHapusSoal;
        private Label lblPilihAksi;
        private ListView listSoal;
        private Button btnKembali;
    }
}
