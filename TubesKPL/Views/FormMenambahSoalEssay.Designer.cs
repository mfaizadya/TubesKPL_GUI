namespace TubesKPL
{
    partial class FormMenambahSoalEssay
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
            labelJudul = new Label();
            btnSelesai = new Button();
            textBoxPertanyaan = new TextBox();
            textBoxJawaban = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // labelJudul
            // 
            labelJudul.AutoSize = true;
            labelJudul.Location = new Point(527, 196);
            labelJudul.Margin = new Padding(6, 0, 6, 0);
            labelJudul.Name = "labelJudul";
            labelJudul.Size = new Size(268, 32);
            labelJudul.TabIndex = 0;
            labelJudul.Text = "Tambah Pertanyaan Esai";
            labelJudul.Click += labelJudul_Click;
            // 
            // btnSelesai
            // 
            btnSelesai.Location = new Point(581, 567);
            btnSelesai.Margin = new Padding(6, 4, 6, 4);
            btnSelesai.Name = "btnSelesai";
            btnSelesai.Size = new Size(152, 47);
            btnSelesai.TabIndex = 1;
            btnSelesai.Text = "Selesai";
            btnSelesai.UseVisualStyleBackColor = true;
            btnSelesai.Click += btnSelesai_Click;
            // 
            // textBoxPertanyaan
            // 
            textBoxPertanyaan.Location = new Point(254, 303);
            textBoxPertanyaan.Margin = new Padding(6, 4, 6, 4);
            textBoxPertanyaan.Name = "textBoxPertanyaan";
            textBoxPertanyaan.Size = new Size(855, 39);
            textBoxPertanyaan.TabIndex = 2;
            textBoxPertanyaan.TextChanged += textBox1_TextChanged;
            // 
            // textBoxJawaban
            // 
            textBoxJawaban.Location = new Point(254, 399);
            textBoxJawaban.Margin = new Padding(6, 4, 6, 4);
            textBoxJawaban.Name = "textBoxJawaban";
            textBoxJawaban.Size = new Size(855, 39);
            textBoxJawaban.TabIndex = 3;
            textBoxJawaban.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 307);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(131, 32);
            label1.TabIndex = 4;
            label1.Text = "Pertanyaan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 403);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(104, 32);
            label2.TabIndex = 5;
            label2.Text = "Jawaban";
            // 
            // FormMenambahSoalEssay
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 721);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxJawaban);
            Controls.Add(textBoxPertanyaan);
            Controls.Add(btnSelesai);
            Controls.Add(labelJudul);
            Margin = new Padding(6, 4, 6, 4);
            Name = "FormMenambahSoalEssay";
            Text = "FormMenambahSoalEssay";
            Load += FormMenambahSoalEssay_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelJudul;
        private Button btnSelesai;
        private TextBox textBoxPertanyaan;
        private TextBox textBoxJawaban;
        private Label label1;
        private Label label2;
    }
}