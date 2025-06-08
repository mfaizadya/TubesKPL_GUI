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
            label1.Location = new Point(395, 12);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 0;
            label1.Text = "Kelola Level";
            label1.Click += label1_Click;
            // 
            // Tambahlv
            // 
            Tambahlv.Location = new Point(679, 116);
            Tambahlv.Margin = new Padding(3, 4, 3, 4);
            Tambahlv.Name = "Tambahlv";
            Tambahlv.Size = new Size(144, 31);
            Tambahlv.TabIndex = 1;
            Tambahlv.Text = "Tambah Level";
            Tambahlv.UseVisualStyleBackColor = true;
            Tambahlv.Click += Tambahlv_Click;
            // 
            // Editlv
            // 
            Editlv.Enabled = false;
            Editlv.Location = new Point(679, 155);
            Editlv.Margin = new Padding(3, 4, 3, 4);
            Editlv.Name = "Editlv";
            Editlv.Size = new Size(144, 31);
            Editlv.TabIndex = 2;
            Editlv.Text = "Edit Nama Level";
            Editlv.UseVisualStyleBackColor = true;
            Editlv.Click += Editlv_Click;
            // 
            // Hapuslv
            // 
            Hapuslv.Enabled = false;
            Hapuslv.Location = new Point(679, 193);
            Hapuslv.Margin = new Padding(3, 4, 3, 4);
            Hapuslv.Name = "Hapuslv";
            Hapuslv.Size = new Size(144, 31);
            Hapuslv.TabIndex = 3;
            Hapuslv.Text = "Hapus Level";
            Hapuslv.UseVisualStyleBackColor = true;
            Hapuslv.Click += Hapuslv_Click;
            // 
            // Kelolalv
            // 
            Kelolalv.Location = new Point(679, 279);
            Kelolalv.Margin = new Padding(3, 4, 3, 4);
            Kelolalv.Name = "Kelolalv";
            Kelolalv.Size = new Size(144, 31);
            Kelolalv.TabIndex = 4;
            Kelolalv.Text = "Kelola Soal";
            Kelolalv.UseVisualStyleBackColor = true;
            Kelolalv.Click += Kelolalv_Click;
            // 
            // listBoxLevel
            // 
            listBoxLevel.Location = new Point(57, 67);
            listBoxLevel.Margin = new Padding(3, 4, 3, 4);
            listBoxLevel.Name = "listBoxLevel";
            listBoxLevel.Size = new Size(571, 384);
            listBoxLevel.TabIndex = 0;
            listBoxLevel.SelectedIndexChanged += listBoxLevel_SelectedIndexChanged;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(741, 526);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(82, 29);
            buttonBack.TabIndex = 11;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // Kelola_Level_dan_Soal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(buttonBack);
            Controls.Add(listBoxLevel);
            Controls.Add(Kelolalv);
            Controls.Add(Hapuslv);
            Controls.Add(Editlv);
            Controls.Add(Tambahlv);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
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