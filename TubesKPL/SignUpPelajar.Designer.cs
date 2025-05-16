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
            SuspendLayout();
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(429, 215);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(221, 27);
            textBoxUsername.TabIndex = 11;
            textBoxUsername.TextChanged += textBoxUsername_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(491, 159);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 10;
            label1.Text = "Sign Up Pelajar";
            label1.Click += label1_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(429, 248);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(221, 27);
            textBoxPassword.TabIndex = 9;
            textBoxPassword.TextChanged += textBoxPassword_TextChanged;
            // 
            // buttonLoginPelajar
            // 
            buttonLoginPelajar.Location = new Point(123, 196);
            buttonLoginPelajar.Name = "buttonLoginPelajar";
            buttonLoginPelajar.Size = new Size(162, 29);
            buttonLoginPelajar.TabIndex = 8;
            buttonLoginPelajar.Text = "Login Pelajar";
            buttonLoginPelajar.UseVisualStyleBackColor = true;
            buttonLoginPelajar.Click += buttonLoginPelajar_Click;
            // 
            // buttonLoginAdmin
            // 
            buttonLoginAdmin.Location = new Point(123, 229);
            buttonLoginAdmin.Name = "buttonLoginAdmin";
            buttonLoginAdmin.Size = new Size(162, 29);
            buttonLoginAdmin.TabIndex = 7;
            buttonLoginAdmin.Text = "Login Admin";
            buttonLoginAdmin.UseVisualStyleBackColor = true;
            buttonLoginAdmin.Click += buttonLoginAdmin_Click;
            // 
            // buttonSignUpPelajar
            // 
            buttonSignUpPelajar.Location = new Point(472, 281);
            buttonSignUpPelajar.Name = "buttonSignUpPelajar";
            buttonSignUpPelajar.Size = new Size(146, 29);
            buttonSignUpPelajar.TabIndex = 6;
            buttonSignUpPelajar.Text = "Sign Up";
            buttonSignUpPelajar.UseVisualStyleBackColor = true;
            buttonSignUpPelajar.Click += buttonSignUpPelajar_Click;
            // 
            // textBoxNama
            // 
            textBoxNama.Location = new Point(429, 182);
            textBoxNama.Name = "textBoxNama";
            textBoxNama.Size = new Size(221, 27);
            textBoxNama.TabIndex = 12;
            textBoxNama.TextChanged += textBoxNama_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(371, 185);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 13;
            label2.Text = "Nama:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(345, 218);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 14;
            label3.Text = "Username:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(350, 251);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 15;
            label4.Text = "Password:";
            // 
            // SignUpPelajar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}