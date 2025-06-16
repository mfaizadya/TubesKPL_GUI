namespace TubesKPL
{
    partial class PelajarLevelView
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
            labelSoal = new Label();
            labelLevel = new Label();
            txtJawaban = new TextBox();
            listBoxOpsi = new ListBox();
            buttonNext = new Button();
            buttonSelesai = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // labelSoal
            // 
            labelSoal.AutoSize = true;
            labelSoal.Location = new Point(54, 82);
            labelSoal.Margin = new Padding(2, 0, 2, 0);
            labelSoal.Name = "labelSoal";
            labelSoal.Size = new Size(32, 15);
            labelSoal.TabIndex = 0;
            labelSoal.Text = "Soal ";
            labelSoal.Click += labelSoal_Click;
            // 
            // labelLevel
            // 
            labelLevel.AutoSize = true;
            labelLevel.Location = new Point(54, 46);
            labelLevel.Margin = new Padding(2, 0, 2, 0);
            labelLevel.Name = "labelLevel";
            labelLevel.Size = new Size(37, 15);
            labelLevel.TabIndex = 1;
            labelLevel.Text = "Level ";
            labelLevel.Click += label1_Click;
            // 
            // txtJawaban
            // 
            txtJawaban.Location = new Point(54, 157);
            txtJawaban.Margin = new Padding(2, 1, 2, 1);
            txtJawaban.Name = "txtJawaban";
            txtJawaban.Size = new Size(266, 23);
            txtJawaban.TabIndex = 2;
            // 
            // listBoxOpsi
            // 
            listBoxOpsi.FormattingEnabled = true;
            listBoxOpsi.ItemHeight = 15;
            listBoxOpsi.Location = new Point(54, 194);
            listBoxOpsi.Margin = new Padding(2, 1, 2, 1);
            listBoxOpsi.Name = "listBoxOpsi";
            listBoxOpsi.Size = new Size(131, 79);
            listBoxOpsi.TabIndex = 3;
            // 
            // buttonNext
            // 
            buttonNext.Location = new Point(413, 214);
            buttonNext.Margin = new Padding(2, 1, 2, 1);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(81, 22);
            buttonNext.TabIndex = 4;
            buttonNext.Text = "Lanjut";
            buttonNext.UseVisualStyleBackColor = true;
            buttonNext.Click += button1_Click;
            // 
            // buttonSelesai
            // 
            buttonSelesai.Location = new Point(497, 214);
            buttonSelesai.Margin = new Padding(2, 1, 2, 1);
            buttonSelesai.Name = "buttonSelesai";
            buttonSelesai.Size = new Size(81, 22);
            buttonSelesai.TabIndex = 5;
            buttonSelesai.Text = "Selesai";
            buttonSelesai.UseVisualStyleBackColor = true;
            buttonSelesai.Click += button1_Click_1;
            // 
            // button1
            // 
            button1.Location = new Point(497, 268);
            button1.Margin = new Padding(2, 1, 2, 1);
            button1.Name = "button1";
            button1.Size = new Size(81, 22);
            button1.TabIndex = 6;
            button1.Text = "Tutup";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_2;
            // 
            // PelajarLevelView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 301);
            Controls.Add(button1);
            Controls.Add(buttonSelesai);
            Controls.Add(buttonNext);
            Controls.Add(listBoxOpsi);
            Controls.Add(txtJawaban);
            Controls.Add(labelLevel);
            Controls.Add(labelSoal);
            Margin = new Padding(2, 1, 2, 1);
            Name = "PelajarLevelView";
            Text = "Levels";
            Load += PelajarLevelView_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSoal;
        private Label labelLevel;
        private TextBox txtJawaban;
        private ListBox listBoxOpsi;
        private Button buttonNext;
        private Button buttonSelesai;
        private Button button1;
    }
}