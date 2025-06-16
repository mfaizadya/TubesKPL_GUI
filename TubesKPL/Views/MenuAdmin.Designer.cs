namespace TubesKPL
{
    partial class MenuAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Bersihkan resource yang digunakan.
        /// </summary>
        /// <param name="disposing">true jika managed resource harus dibersihkan; false sebaliknya.</param>
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
        /// Jangan ubah isi method ini menggunakan editor code biasa.
        /// Gunakan Windows Forms Designer.
        /// </summary>
        private void InitializeComponent()
        {
            labelJudul = new Label();
            buttonKelolaLevel = new Button();
            buttonLihatHasil = new Button();
            buttonKeluar = new Button();
            labelNama = new Label();

            SuspendLayout();

            // 
            // labelJudul
            // 
            labelJudul.AutoSize = true;
            labelJudul.Location = new Point(353, 40);
            labelJudul.Name = "labelJudul";
            labelJudul.Size = new Size(77, 15);
            labelJudul.TabIndex = 0;
            labelJudul.Text = "Menu Admin";

            // 
            // buttonKelolaLevel
            // 
            buttonKelolaLevel.Location = new Point(277, 80);
            buttonKelolaLevel.Name = "buttonKelolaLevel";
            buttonKelolaLevel.Size = new Size(216, 23);
            buttonKelolaLevel.TabIndex = 2;
            buttonKelolaLevel.Text = "Mengelola Level dan Soal";
            buttonKelolaLevel.UseVisualStyleBackColor = true;
            buttonKelolaLevel.Click += ButtonKelolaLevel_Click;

            // 
            // buttonLihatHasil
            // 
            buttonLihatHasil.Location = new Point(277, 123);
            buttonLihatHasil.Name = "buttonLihatHasil";
            buttonLihatHasil.Size = new Size(216, 23);
            buttonLihatHasil.TabIndex = 3;
            buttonLihatHasil.Text = "Melihat Hasil Pelajar dan Menilai";
            buttonLihatHasil.UseVisualStyleBackColor = true;
            buttonLihatHasil.Click += ButtonReviewAttempt_Click;

            // 
            // buttonKeluar
            // 
            buttonKeluar.Location = new Point(586, 32);
            buttonKeluar.Name = "buttonKeluar";
            buttonKeluar.Size = new Size(75, 23);
            buttonKeluar.TabIndex = 4;
            buttonKeluar.Text = "Keluar";
            buttonKeluar.UseVisualStyleBackColor = true;
            buttonKeluar.Click += ButtonLogout_Click;

            // 
            // labelNama
            // 
            labelNama.AutoSize = true;
            labelNama.Location = new Point(10, 32);
            labelNama.Name = "labelNama";
            labelNama.Size = new Size(0, 15);
            labelNama.TabIndex = 5;

            // 
            // MenuAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelNama);
            Controls.Add(buttonKeluar);
            Controls.Add(buttonLihatHasil);
            Controls.Add(buttonKelolaLevel);
            Controls.Add(labelJudul);
            Name = "MenuAdmin";
            Text = "Menu Admin";
            Load += MenuAdmin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelJudul;
        private Button buttonKelolaLevel;
        private Button buttonLihatHasil;
        private Button buttonKeluar;
        private Label labelNama;
    }
}
