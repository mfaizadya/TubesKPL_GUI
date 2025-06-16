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
            labelOutput = new Label();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(590, 385);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(131, 32);
            label4.TabIndex = 25;
            label4.Text = "Kata Sandi:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(525, 331);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(196, 32);
            label3.TabIndex = 24;
            label3.Text = "Nama Pengguna:";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(720, 328);
            textBoxUsername.Margin = new Padding(5, 5, 5, 5);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(357, 39);
            textBoxUsername.TabIndex = 21;
            textBoxUsername.TextChanged += textBoxUsername_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(821, 293);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(161, 32);
            label1.TabIndex = 20;
            label1.Text = "Masuk Admin";
            label1.Click += label1_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(720, 382);
            textBoxPassword.Margin = new Padding(5, 5, 5, 5);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(357, 39);
            textBoxPassword.TabIndex = 19;
            // 
            // buttonLoginPelajar
            // 
            buttonLoginPelajar.Location = new Point(197, 354);
            buttonLoginPelajar.Margin = new Padding(5, 5, 5, 5);
            buttonLoginPelajar.Name = "buttonLoginPelajar";
            buttonLoginPelajar.Size = new Size(263, 46);
            buttonLoginPelajar.TabIndex = 18;
            buttonLoginPelajar.Text = "Masuk Pelajar";
            buttonLoginPelajar.UseVisualStyleBackColor = true;
            buttonLoginPelajar.Click += buttonLoginPelajar_Click;
            // 
            // buttonLoginAdmin
            // 
            buttonLoginAdmin.Location = new Point(769, 435);
            buttonLoginAdmin.Margin = new Padding(5, 5, 5, 5);
            buttonLoginAdmin.Name = "buttonLoginAdmin";
            buttonLoginAdmin.Size = new Size(263, 46);
            buttonLoginAdmin.TabIndex = 17;
            buttonLoginAdmin.Text = "Masuk Admin";
            buttonLoginAdmin.UseVisualStyleBackColor = true;
            buttonLoginAdmin.Click += buttonLoginAdmin_Click;
            // 
            // labelOutput
            // 
            labelOutput.AutoSize = true;
            labelOutput.Location = new Point(720, 504);
            labelOutput.Margin = new Padding(5, 0, 5, 0);
            labelOutput.Name = "labelOutput";
            labelOutput.Size = new Size(0, 32);
            labelOutput.TabIndex = 26;
            labelOutput.Click += label2_Click;
            // 
            // LoginAdmin
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 722);
            Controls.Add(labelOutput);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxUsername);
            Controls.Add(label1);
            Controls.Add(textBoxPassword);
            Controls.Add(buttonLoginPelajar);
            Controls.Add(buttonLoginAdmin);
            Margin = new Padding(5, 5, 5, 5);
            Name = "LoginAdmin";
            Text = "LoginAdmin";
            Load += LoginAdmin_Load;
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
        private Label labelOutput;
    }
}