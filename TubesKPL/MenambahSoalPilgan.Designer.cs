namespace TubesKPL
{
    partial class MenambahSoalPilgan
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
            txtSoal = new TextBox();
            txtOption = new TextBox();
            btnAddOption = new Button();
            lstOptions = new ListBox();
            txtJawaban = new TextBox();
            btnSimpan = new Button();
            SuspendLayout();
            // 
            // txtSoal
            // 
            txtSoal.Location = new Point(42, 41);
            txtSoal.Multiline = true;
            txtSoal.Name = "txtSoal";
            txtSoal.Size = new Size(497, 43);
            txtSoal.TabIndex = 0;
            txtSoal.TextChanged += txtSoal_TextChanged;
            // 
            // txtOption
            // 
            txtOption.Location = new Point(40, 102);
            txtOption.Name = "txtOption";
            txtOption.Size = new Size(303, 23);
            txtOption.TabIndex = 1;
            txtOption.TextChanged += txtOption_TextChanged;
            // 
            // btnAddOption
            // 
            btnAddOption.Location = new Point(366, 104);
            btnAddOption.Name = "btnAddOption";
            btnAddOption.Size = new Size(55, 21);
            btnAddOption.TabIndex = 2;
            btnAddOption.Text = "input";
            btnAddOption.UseVisualStyleBackColor = true;
            btnAddOption.Click += btnAddOption_Click;
            // 
            // lstOptions
            // 
            lstOptions.FormattingEnabled = true;
            lstOptions.ItemHeight = 15;
            lstOptions.Location = new Point(41, 145);
            lstOptions.Name = "lstOptions";
            lstOptions.Size = new Size(426, 154);
            lstOptions.TabIndex = 3;
            lstOptions.SelectedIndexChanged += lstOptions_SelectedIndexChanged;
            // 
            // txtJawaban
            // 
            txtJawaban.Location = new Point(42, 334);
            txtJawaban.Name = "txtJawaban";
            txtJawaban.Size = new Size(434, 23);
            txtJawaban.TabIndex = 4;
            txtJawaban.TextChanged += txtJawaban_TextChanged;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(457, 393);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(82, 22);
            btnSimpan.TabIndex = 5;
            btnSimpan.Text = "Selesai";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // MenambahSoalPilgan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSimpan);
            Controls.Add(txtJawaban);
            Controls.Add(lstOptions);
            Controls.Add(btnAddOption);
            Controls.Add(txtOption);
            Controls.Add(txtSoal);
            Name = "MenambahSoalPilgan";
            Text = "MenambahSoalPilgan";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSoal;
        private TextBox txtOption;
        private Button btnAddOption;
        private ListBox lstOptions;
        private TextBox txtJawaban;
        private Button btnSimpan;
    }
}