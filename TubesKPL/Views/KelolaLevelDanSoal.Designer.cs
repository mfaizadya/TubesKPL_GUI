namespace TubesKPL
{
    partial class KelolaLevelDanSoal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Bersihkan resource yang sedang digunakan.
        /// </summary>
        /// <param name="disposing">true jika resource dikelola perlu dibersihkan; false jika tidak.</param>
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
        /// Metode ini diperlukan untuk mendukung designer.
        /// Jangan modifikasi isinya dengan code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelKelolaLevel = new Label();
            buttonTambahLevel = new Button();
            buttonEditLevel = new Button();
            buttonHapusLevel = new Button();
            buttonKelolaSoal = new Button();
            listBoxLevel = new ListBox();
            buttonBack = new Button();
            SuspendLayout();

            // 
            // labelKelolaLevel
            // 
            labelKelolaLevel.AutoSize = true;
            labelKelolaLevel.Location = new Point(345, 19);
            labelKelolaLevel.Name = "labelKelolaLevel";
            labelKelolaLevel.Size = new Size(69, 15);
            labelKelolaLevel.TabIndex = 0;
            labelKelolaLevel.Text = "Kelola Level";
            

            // 
            // buttonTambahLevel
            // 
            buttonTambahLevel.Location = new Point(594, 87);
            buttonTambahLevel.Name = "buttonTambahLevel";
            buttonTambahLevel.Size = new Size(126, 23);
            buttonTambahLevel.TabIndex = 1;
            buttonTambahLevel.Text = "Tambah Level";
            buttonTambahLevel.UseVisualStyleBackColor = true;
            buttonTambahLevel.Click += ButtonTambahLevel_Click;

            // 
            // buttonEditLevel
            // 
            buttonEditLevel.Enabled = false;
            buttonEditLevel.Location = new Point(594, 116);
            buttonEditLevel.Name = "buttonEditLevel";
            buttonEditLevel.Size = new Size(126, 23);
            buttonEditLevel.TabIndex = 2;
            buttonEditLevel.Text = "Edit Nama Level";
            buttonEditLevel.UseVisualStyleBackColor = true;
            buttonEditLevel.Click += ButtonEditLevel_Click;

            // 
            // buttonHapusLevel
            // 
            buttonHapusLevel.Enabled = false;
            buttonHapusLevel.Location = new Point(594, 145);
            buttonHapusLevel.Name = "buttonHapusLevel";
            buttonHapusLevel.Size = new Size(126, 23);
            buttonHapusLevel.TabIndex = 3;
            buttonHapusLevel.Text = "Hapus Level";
            buttonHapusLevel.UseVisualStyleBackColor = true;
            buttonHapusLevel.Click += ButtonHapusLevel_Click;

            // 
            // buttonKelolaSoal
            // 
            buttonKelolaSoal.Location = new Point(594, 209);
            buttonKelolaSoal.Name = "buttonKelolaSoal";
            buttonKelolaSoal.Size = new Size(126, 23);
            buttonKelolaSoal.TabIndex = 4;
            buttonKelolaSoal.Text = "Kelola Soal";
            buttonKelolaSoal.UseVisualStyleBackColor = true;
            buttonKelolaSoal.Click += ButtonKelolaSoal_Click;

            // 
            // listBoxLevel
            // 
            listBoxLevel.ItemHeight = 15;
            listBoxLevel.Location = new Point(50, 50);
            listBoxLevel.Name = "listBoxLevel";
            listBoxLevel.Size = new Size(500, 289);
            listBoxLevel.TabIndex = 0;
            listBoxLevel.SelectedIndexChanged += ListBoxLevel_SelectedIndexChanged;

            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(594, 317);
            buttonBack.Margin = new Padding(3, 2, 3, 2);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(126, 22);
            buttonBack.TabIndex = 11;
            buttonBack.Text = "Kembali";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += ButtonBack_Click;

            // 
            // KelolaLevelDanSoal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 357);
            Controls.Add(buttonBack);
            Controls.Add(listBoxLevel);
            Controls.Add(buttonKelolaSoal);
            Controls.Add(buttonHapusLevel);
            Controls.Add(buttonEditLevel);
            Controls.Add(buttonTambahLevel);
            Controls.Add(labelKelolaLevel);
            Name = "KelolaLevelDanSoal";
            Text = "Kelola Level dan Soal";
            Load += KelolaLevelDanSoal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelKelolaLevel;
        private Button buttonTambahLevel;
        private Button buttonEditLevel;
        private Button buttonHapusLevel;
        private Button buttonKelolaSoal;
        private ListBox listBoxLevel;
        private Button buttonBack;
    }
}
