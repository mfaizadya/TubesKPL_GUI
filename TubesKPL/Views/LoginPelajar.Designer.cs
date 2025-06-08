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
            buttonSignUpPelajar.Location = new Point(128, 211);
            buttonSignUpPelajar.Name = "buttonSignUpPelajar";
            buttonSignUpPelajar.Size = new Size(146, 29);
            buttonSignUpPelajar.TabIndex = 0;
            buttonSignUpPelajar.Text = "Sign Up Pelajar";
            buttonSignUpPelajar.UseVisualStyleBackColor = true;
            buttonSignUpPelajar.Click += buttonSignUpPelajar_Click;
            // 
            // buttonLoginAdmin
            // 
            buttonLoginAdmin.Location = new Point(128, 246);
            buttonLoginAdmin.Name = "buttonLoginAdmin";
            buttonLoginAdmin.Size = new Size(146, 29);
            buttonLoginAdmin.TabIndex = 1;
            buttonLoginAdmin.Text = "Login Admin";
            buttonLoginAdmin.UseVisualStyleBackColor = true;
            buttonLoginAdmin.Click += button2_Click;
            // 
            // buttonLoginPelajar
            // 
            buttonLoginPelajar.Location = new Point(458, 279);
            buttonLoginPelajar.Name = "buttonLoginPelajar";
            buttonLoginPelajar.Size = new Size(162, 29);
            buttonLoginPelajar.TabIndex = 2;
            buttonLoginPelajar.Text = "Login";
            buttonLoginPelajar.UseVisualStyleBackColor = true;
            buttonLoginPelajar.Click += button3_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(429, 246);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(221, 27);
            textBoxPassword.TabIndex = 3;
            textBoxPassword.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(486, 190);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 4;
            label1.Text = "Login Pelajar";
            label1.Click += label1_Click;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(429, 213);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(221, 27);
            textBoxUsername.TabIndex = 5;
            textBoxUsername.TextChanged += textBoxUsername_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(345, 216);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 6;
            label2.Text = "Username:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(350, 248);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 7;
            label3.Text = "Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.System;
            label4.Location = new Point(264, 107);
            label4.Name = "label4";
            label4.Size = new Size(202, 20);
            label4.TabIndex = 8;
            label4.Text = "Selamat Datang di LogiLearn";
            label4.Click += label4_Click;
            // 
            // labelOutput
            // 
            labelOutput.AutoSize = true;
            labelOutput.Location = new Point(429, 311);
            labelOutput.Name = "labelOutput";
            labelOutput.Size = new Size(0, 20);
            labelOutput.TabIndex = 9;
            // 
            // LoginPelajar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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