namespace TubesKPL
{
    partial class NilaiEsai
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
            cmbPelajar = new ComboBox();
            txtJawabanEsai = new TextBox();
            txtSkorMax = new TextBox();
            txtSkorPelajar = new TextBox();
            btnSimpan = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // cmbPelajar
            // 
            cmbPelajar.FormattingEnabled = true;
            cmbPelajar.Location = new Point(43, 57);
            cmbPelajar.Name = "cmbPelajar";
            cmbPelajar.Size = new Size(294, 23);
            cmbPelajar.TabIndex = 0;
            cmbPelajar.SelectedIndexChanged += cmbPelajar_SelectedIndexChanged;
            // 
            // txtJawabanEsai
            // 
            txtJawabanEsai.Location = new Point(43, 111);
            txtJawabanEsai.Multiline = true;
            txtJawabanEsai.Name = "txtJawabanEsai";
            txtJawabanEsai.Size = new Size(481, 84);
            txtJawabanEsai.TabIndex = 1;
            txtJawabanEsai.TextChanged += txtJawabanEsai_TextChanged;
            // 
            // txtSkorMax
            // 
            txtSkorMax.Location = new Point(123, 220);
            txtSkorMax.Name = "txtSkorMax";
            txtSkorMax.Size = new Size(48, 23);
            txtSkorMax.TabIndex = 2;
            txtSkorMax.TextChanged += txtSkorMax_TextChanged;
            // 
            // txtSkorPelajar
            // 
            txtSkorPelajar.Location = new Point(123, 268);
            txtSkorPelajar.Name = "txtSkorPelajar";
            txtSkorPelajar.Size = new Size(48, 23);
            txtSkorPelajar.TabIndex = 3;
            txtSkorPelajar.TextChanged += txtSkorPelajar_TextChanged;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(437, 284);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(87, 32);
            btnSimpan.TabIndex = 4;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 223);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 5;
            label1.Text = "Skor max: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 271);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 6;
            label2.Text = "Skor pelajar: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 39);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 7;
            label3.Text = "Pilih ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 93);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 8;
            label4.Text = "Jawaban";
            // 
            // button1
            // 
            button1.Location = new Point(637, 370);
            button1.Name = "button1";
            button1.Size = new Size(59, 23);
            button1.TabIndex = 9;
            button1.Text = "back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // NilaiEsai
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSimpan);
            Controls.Add(txtSkorPelajar);
            Controls.Add(txtSkorMax);
            Controls.Add(txtJawabanEsai);
            Controls.Add(cmbPelajar);
            Name = "NilaiEsai";
            Text = "NilaiEsai";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbPelajar;
        private TextBox txtJawabanEsai;
        private TextBox txtSkorMax;
        private TextBox txtSkorPelajar;
        private Button btnSimpan;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
    }
}