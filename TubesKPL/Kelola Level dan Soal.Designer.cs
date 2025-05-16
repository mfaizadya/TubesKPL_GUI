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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(346, 9);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 0;
            label1.Text = "Kelola Level";
            label1.Click += label1_Click;
            // 
            // Tambahlv
            // 
            Tambahlv.Location = new Point(594, 87);
            Tambahlv.Name = "Tambahlv";
            Tambahlv.Size = new Size(126, 23);
            Tambahlv.TabIndex = 1;
            Tambahlv.Text = "Tambah Level";
            Tambahlv.UseVisualStyleBackColor = true;
            Tambahlv.Click += Tambahlv_Click;
            // 
            // Editlv
            // 
            Editlv.Location = new Point(594, 116);
            Editlv.Name = "Editlv";
            Editlv.Size = new Size(126, 23);
            Editlv.TabIndex = 2;
            Editlv.Text = "Edit Level";
            Editlv.UseVisualStyleBackColor = true;
            Editlv.Click += Editlv_Click;
            // 
            // Hapuslv
            // 
            Hapuslv.Location = new Point(594, 145);
            Hapuslv.Name = "Hapuslv";
            Hapuslv.Size = new Size(126, 23);
            Hapuslv.TabIndex = 3;
            Hapuslv.Text = "Hapus Level";
            Hapuslv.UseVisualStyleBackColor = true;
            Hapuslv.Click += Hapuslv_Click;
            // 
            // Kelolalv
            // 
            Kelolalv.Location = new Point(594, 209);
            Kelolalv.Name = "Kelolalv";
            Kelolalv.Size = new Size(126, 23);
            Kelolalv.TabIndex = 4;
            Kelolalv.Text = "Kelola Soal";
            Kelolalv.UseVisualStyleBackColor = true;
            Kelolalv.Click += Kelolalv_Click;

            listBoxLevel = new ListBox();
            listBoxLevel.Location = new Point(50, 50);
            listBoxLevel.Size = new Size(500, 300);
            listBoxLevel.SelectedIndexChanged += listBoxLevel_SelectedIndexChanged;

            Controls.Add(listBoxLevel);
            Editlv.Enabled = false;
            Hapuslv.Enabled = false;


            // 
            // Kelola_Level_dan_Soal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Kelolalv);
            Controls.Add(Hapuslv);
            Controls.Add(Editlv);
            Controls.Add(Tambahlv);
            Controls.Add(label1);
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
    }
}