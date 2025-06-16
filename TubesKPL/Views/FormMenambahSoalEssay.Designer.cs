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
            Button_Kembali = new Button();
            SuspendLayout();
            // 
            // labelJudul
            // 
            labelJudul.AutoSize = true;
            labelJudul.Location = new Point(284, 92);
            labelJudul.Name = "labelJudul";
            labelJudul.Size = new Size(134, 15);
            labelJudul.TabIndex = 0;
            labelJudul.Text = "Tambah Pertanyaan Esai";
            // 
            // btnSelesai
            // 
            btnSelesai.Location = new Point(313, 266);
            btnSelesai.Margin = new Padding(3, 2, 3, 2);
            btnSelesai.Name = "btnSelesai";
            btnSelesai.Size = new Size(82, 22);
            btnSelesai.TabIndex = 1;
            btnSelesai.Text = "Selesai";
            btnSelesai.UseVisualStyleBackColor = true;
            btnSelesai.Click += BtnSelesai_Click;
            // 
            // textBoxPertanyaan
            // 
            textBoxPertanyaan.Location = new Point(137, 142);
            textBoxPertanyaan.Margin = new Padding(3, 2, 3, 2);
            textBoxPertanyaan.Name = "textBoxPertanyaan";
            textBoxPertanyaan.Size = new Size(462, 23);
            textBoxPertanyaan.TabIndex = 2;
            // 
            // textBoxJawaban
            // 
            textBoxJawaban.Location = new Point(137, 187);
            textBoxJawaban.Margin = new Padding(3, 2, 3, 2);
            textBoxJawaban.Name = "textBoxJawaban";
            textBoxJawaban.Size = new Size(462, 23);
            textBoxJawaban.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 144);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 4;
            label1.Text = "Pertanyaan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 189);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 5;
            label2.Text = "Jawaban";
            // 
            // Button_Kembali
            // 
            Button_Kembali.Location = new Point(536, 266);
            Button_Kembali.Name = "Button_Kembali";
            Button_Kembali.Size = new Size(75, 23);
            Button_Kembali.TabIndex = 6;
            Button_Kembali.Text = "Kembali";
            Button_Kembali.UseVisualStyleBackColor = true;
            Button_Kembali.Click += BtnKembali_Click;
            // 
            // FormMenambahSoalEssay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(Button_Kembali);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxJawaban);
            Controls.Add(textBoxPertanyaan);
            Controls.Add(btnSelesai);
            Controls.Add(labelJudul);
            Margin = new Padding(3, 2, 3, 2);
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
        private Button Button_Kembali;
    }
}