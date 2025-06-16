namespace TubesKPL
{
    partial class LoginPelajar
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
            buttonSignUpPelajar = new Button();
            buttonLoginAdmin = new Button();
            buttonLoginPelajar = new Button();
            textBoxPassword = new TextBox();
            label1 = new Label();
            textBoxUsername = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            labelOutput = new Label();
            SuspendLayout();
            // 
            // buttonSignUpPelajar
            // 
            buttonSignUpPelajar.Location = new Point(208, 338);
            buttonSignUpPelajar.Margin = new Padding(5, 5, 5, 5);
            buttonSignUpPelajar.Name = "buttonSignUpPelajar";
            buttonSignUpPelajar.Size = new Size(237, 46);
            buttonSignUpPelajar.TabIndex = 0;
            buttonSignUpPelajar.Text = "Buat Akun Pelajar";
            buttonSignUpPelajar.UseVisualStyleBackColor = true;
            buttonSignUpPelajar.Click += buttonSignUpPelajar_Click;
            // 
            // buttonLoginAdmin
            // 
            buttonLoginAdmin.Location = new Point(208, 394);
            buttonLoginAdmin.Margin = new Padding(5, 5, 5, 5);
            buttonLoginAdmin.Name = "buttonLoginAdmin";
            buttonLoginAdmin.Size = new Size(237, 46);
            buttonLoginAdmin.TabIndex = 1;
            buttonLoginAdmin.Text = "Masuk Admin";
            buttonLoginAdmin.UseVisualStyleBackColor = true;
            buttonLoginAdmin.Click += button2_Click;
            // 
            // buttonLoginPelajar
            // 
            buttonLoginPelajar.Location = new Point(744, 446);
            buttonLoginPelajar.Margin = new Padding(5, 5, 5, 5);
            buttonLoginPelajar.Name = "buttonLoginPelajar";
            buttonLoginPelajar.Size = new Size(263, 46);
            buttonLoginPelajar.TabIndex = 2;
            buttonLoginPelajar.Text = "Masuk";
            buttonLoginPelajar.UseVisualStyleBackColor = true;
            buttonLoginPelajar.Click += button3_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(697, 394);
            textBoxPassword.Margin = new Padding(5, 5, 5, 5);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(357, 39);
            textBoxPassword.TabIndex = 3;
            textBoxPassword.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(790, 304);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(160, 32);
            label1.TabIndex = 4;
            label1.Text = "Masuk Pelajar";
            label1.Click += label1_Click;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(697, 341);
            textBoxUsername.Margin = new Padding(5, 5, 5, 5);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(357, 39);
            textBoxUsername.TabIndex = 5;
            textBoxUsername.TextChanged += textBoxUsername_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(491, 338);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(196, 32);
            label2.TabIndex = 6;
            label2.Text = "Nama Pengguna:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(556, 394);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(131, 32);
            label3.TabIndex = 7;
            label3.Text = "Kata Sandi:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.System;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(429, 171);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(427, 45);
            label4.TabIndex = 8;
            label4.Text = "Selamat Datang di LogiLearn";
            label4.Click += label4_Click;
            // 
            // labelOutput
            // 
            labelOutput.AutoSize = true;
            labelOutput.Location = new Point(697, 498);
            labelOutput.Margin = new Padding(5, 0, 5, 0);
            labelOutput.Name = "labelOutput";
            labelOutput.Size = new Size(0, 32);
            labelOutput.TabIndex = 9;
            // 
            // LoginPelajar
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 720);
            Controls.Add(labelOutput);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxUsername);
            Controls.Add(label1);
            Controls.Add(textBoxPassword);
            Controls.Add(buttonLoginPelajar);
            Controls.Add(buttonLoginAdmin);
            Controls.Add(buttonSignUpPelajar);
            Margin = new Padding(5, 5, 5, 5);
            Name = "LoginPelajar";
            Text = "LOGILEARN";
            Load += LoginPelajar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSignUpPelajar;
        private Button buttonLoginAdmin;
        private Button buttonLoginPelajar;
        private TextBox textBoxPassword;
        private Label label1;
        private TextBox textBoxUsername;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label labelOutput;
    }
}