namespace TubesKPL
{
    partial class LoginAdmin
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
            label4 = new Label();
            label3 = new Label();
            textBoxUsername = new TextBox();
            label1 = new Label();
            textBoxPassword = new TextBox();
            buttonLoginPelajar = new Button();
            buttonLoginAdmin = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(364, 242);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 25;
            label4.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(359, 209);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 24;
            label3.Text = "Username:";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(443, 206);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(221, 27);
            textBoxUsername.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(505, 183);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 20;
            label1.Text = "Login Admin";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(443, 239);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(221, 27);
            textBoxPassword.TabIndex = 19;
            // 
            // buttonLoginPelajar
            // 
            buttonLoginPelajar.Location = new Point(121, 222);
            buttonLoginPelajar.Name = "buttonLoginPelajar";
            buttonLoginPelajar.Size = new Size(162, 29);
            buttonLoginPelajar.TabIndex = 18;
            buttonLoginPelajar.Text = "Login Pelajar";
            buttonLoginPelajar.UseVisualStyleBackColor = true;
            buttonLoginPelajar.Click += buttonLoginPelajar_Click;
            // 
            // buttonLoginAdmin
            // 
            buttonLoginAdmin.Location = new Point(473, 272);
            buttonLoginAdmin.Name = "buttonLoginAdmin";
            buttonLoginAdmin.Size = new Size(162, 29);
            buttonLoginAdmin.TabIndex = 17;
            buttonLoginAdmin.Text = "Login Admin";
            buttonLoginAdmin.UseVisualStyleBackColor = true;
            buttonLoginAdmin.Click += buttonLoginAdmin_Click;
            // 
            // LoginAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxUsername);
            Controls.Add(label1);
            Controls.Add(textBoxPassword);
            Controls.Add(buttonLoginPelajar);
            Controls.Add(buttonLoginAdmin);
            Name = "LoginAdmin";
            Text = "LoginAdmin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private TextBox textBoxUsername;
        private Label label1;
        private TextBox textBoxPassword;
        private Button buttonLoginPelajar;
        private Button buttonLoginAdmin;
    }
}