namespace TubesKPL
{
    partial class Kelola_Level_dan_Soal
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
            label1 = new Label();
            Tambahlv = new Button();
            Editlv = new Button();
            Hapuslv = new Button();
            Kelolalv = new Button();
            listBoxLevel = new ListBox();
            buttonBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(641, 41);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(141, 32);
            label1.TabIndex = 0;
            label1.Text = "Kelola Level";
            label1.Click += label1_Click;
            // 
            // Tambahlv
            // 
            Tambahlv.Location = new Point(1103, 186);
            Tambahlv.Margin = new Padding(5, 6, 5, 6);
            Tambahlv.Name = "Tambahlv";
            Tambahlv.Size = new Size(234, 50);
            Tambahlv.TabIndex = 1;
            Tambahlv.Text = "Tambah Level";
            Tambahlv.UseVisualStyleBackColor = true;
            Tambahlv.Click += Tambahlv_Click;
            // 
            // Editlv
            // 
            Editlv.Enabled = false;
            Editlv.Location = new Point(1103, 248);
            Editlv.Margin = new Padding(5, 6, 5, 6);
            Editlv.Name = "Editlv";
            Editlv.Size = new Size(234, 50);
            Editlv.TabIndex = 2;
            Editlv.Text = "Edit Nama Level";
            Editlv.UseVisualStyleBackColor = true;
            Editlv.Click += Editlv_Click;
            // 
            // Hapuslv
            // 
            Hapuslv.Enabled = false;
            Hapuslv.Location = new Point(1103, 309);
            Hapuslv.Margin = new Padding(5, 6, 5, 6);
            Hapuslv.Name = "Hapuslv";
            Hapuslv.Size = new Size(234, 50);
            Hapuslv.TabIndex = 3;
            Hapuslv.Text = "Hapus Level";
            Hapuslv.UseVisualStyleBackColor = true;
            Hapuslv.Click += Hapuslv_Click;
            // 
            // Kelolalv
            // 
            Kelolalv.Location = new Point(1103, 446);
            Kelolalv.Margin = new Padding(5, 6, 5, 6);
            Kelolalv.Name = "Kelolalv";
            Kelolalv.Size = new Size(234, 50);
            Kelolalv.TabIndex = 4;
            Kelolalv.Text = "Kelola Soal";
            Kelolalv.UseVisualStyleBackColor = true;
            Kelolalv.Click += Kelolalv_Click;
            // 
            // listBoxLevel
            // 
            listBoxLevel.Location = new Point(93, 107);
            listBoxLevel.Margin = new Padding(5, 6, 5, 6);
            listBoxLevel.Name = "listBoxLevel";
            listBoxLevel.Size = new Size(925, 612);
            listBoxLevel.TabIndex = 0;
            listBoxLevel.SelectedIndexChanged += listBoxLevel_SelectedIndexChanged;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(1204, 842);
            buttonBack.Margin = new Padding(5);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(133, 46);
            buttonBack.TabIndex = 11;
            buttonBack.Text = "Kembali";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // Kelola_Level_dan_Soal
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1485, 960);
            Controls.Add(buttonBack);
            Controls.Add(listBoxLevel);
            Controls.Add(Kelolalv);
            Controls.Add(Hapuslv);
            Controls.Add(Editlv);
            Controls.Add(Tambahlv);
            Controls.Add(label1);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Kelola_Level_dan_Soal";
            Text = "Kelola_Level_dan_Soal";
            Load += Kelola_Level_dan_Soal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button Tambahlv;
        private Button Editlv;
        private Button Hapuslv;
        private Button Kelolalv;
        private ListBox listBoxLevel;
        private Button buttonBack;
    }
}