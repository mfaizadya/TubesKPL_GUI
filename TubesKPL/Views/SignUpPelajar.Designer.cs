namespace TubesKPL
{
    partial class SignUpPelajar
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
            textBoxUsername = new TextBox();
            label1 = new Label();
            textBoxPassword = new TextBox();
            buttonLoginPelajar = new Button();
            buttonLoginAdmin = new Button();
            buttonSignUpPelajar = new Button();
            textBoxNama = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            labelOutput = new Label();
            SuspendLayout();
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(697, 344);
            textBoxUsername.Margin = new Padding(5);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(357, 39);
            textBoxUsername.TabIndex = 11;
            textBoxUsername.TextChanged += textBoxUsername_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(798, 254);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(200, 32);
            label1.TabIndex = 10;
            label1.Text = "Buat Akun Pelajar";
            label1.Click += label1_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(697, 397);
            textBoxPassword.Margin = new Padding(5);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(357, 39);
            textBoxPassword.TabIndex = 9;
            textBoxPassword.TextChanged += textBoxPassword_TextChanged;
            // 
            // buttonLoginPelajar
            // 
            buttonLoginPelajar.Location = new Point(200, 314);
            buttonLoginPelajar.Margin = new Padding(5);
            buttonLoginPelajar.Name = "buttonLoginPelajar";
            buttonLoginPelajar.Size = new Size(263, 46);
            buttonLoginPelajar.TabIndex = 8;
            buttonLoginPelajar.Text = "Masuk Pelajar";
            buttonLoginPelajar.UseVisualStyleBackColor = true;
            buttonLoginPelajar.Click += buttonLoginPelajar_Click;
            // 
            // buttonLoginAdmin
            // 
            buttonLoginAdmin.Location = new Point(200, 366);
            buttonLoginAdmin.Margin = new Padding(5);
            buttonLoginAdmin.Name = "buttonLoginAdmin";
            buttonLoginAdmin.Size = new Size(263, 46);
            buttonLoginAdmin.TabIndex = 7;
            buttonLoginAdmin.Text = "Masuk Admin";
            buttonLoginAdmin.UseVisualStyleBackColor = true;
            buttonLoginAdmin.Click += buttonLoginAdmin_Click;
            // 
            // buttonSignUpPelajar
            // 
            buttonSignUpPelajar.Location = new Point(767, 450);
            buttonSignUpPelajar.Margin = new Padding(5);
            buttonSignUpPelajar.Name = "buttonSignUpPelajar";
            buttonSignUpPelajar.Size = new Size(237, 46);
            buttonSignUpPelajar.TabIndex = 6;
            buttonSignUpPelajar.Text = "Buat Akun";
            buttonSignUpPelajar.UseVisualStyleBackColor = true;
            buttonSignUpPelajar.Click += buttonSignUpPelajar_Click;
            // 
            // textBoxNama
            // 
            textBoxNama.Location = new Point(697, 291);
            textBoxNama.Margin = new Padding(5);
            textBoxNama.Name = "textBoxNama";
            textBoxNama.Size = new Size(357, 39);
            textBoxNama.TabIndex = 12;
            textBoxNama.TextChanged += textBoxNama_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(603, 296);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(82, 32);
            label2.TabIndex = 13;
            label2.Text = "Nama:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(499, 347);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(196, 32);
            label3.TabIndex = 14;
            label3.Text = "Nama Pengguna:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(569, 402);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(126, 32);
            label4.TabIndex = 15;
            label4.Text = "Kata Sandi";
            // 
            // labelOutput
            // 
            labelOutput.AutoSize = true;
            labelOutput.Location = new Point(798, 519);
            labelOutput.Margin = new Padding(5, 0, 5, 0);
            labelOutput.Name = "labelOutput";
            labelOutput.Size = new Size(0, 32);
            labelOutput.TabIndex = 16;
            // 
            // SignUpPelajar
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 720);
            Controls.Add(labelOutput);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxNama);
            Controls.Add(textBoxUsername);
            Controls.Add(label1);
            Controls.Add(textBoxPassword);
            Controls.Add(buttonLoginPelajar);
            Controls.Add(buttonLoginAdmin);
            Controls.Add(buttonSignUpPelajar);
            Margin = new Padding(5);
            Name = "SignUpPelajar";
            Text = "SignUpPelajar";
            Load += SignUpPelajar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxUsername;
        private Label label1;
        private TextBox textBoxPassword;
        private Button buttonLoginPelajar;
        private Button buttonLoginAdmin;
        private Button buttonSignUpPelajar;
        private TextBox textBoxNama;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label labelOutput;
    }
}