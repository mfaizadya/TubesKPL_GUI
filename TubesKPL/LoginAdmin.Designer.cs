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
            label4.Location = new Point(318, 182);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 25;
            label4.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(314, 157);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 24;
            label3.Text = "Username:";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(388, 154);
            textBoxUsername.Margin = new Padding(3, 2, 3, 2);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(194, 23);
            textBoxUsername.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(442, 137);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 20;
            label1.Text = "Login Admin";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(388, 179);
            textBoxPassword.Margin = new Padding(3, 2, 3, 2);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(194, 23);
            textBoxPassword.TabIndex = 19;
            // 
            // buttonLoginPelajar
            // 
            buttonLoginPelajar.Location = new Point(106, 166);
            buttonLoginPelajar.Margin = new Padding(3, 2, 3, 2);
            buttonLoginPelajar.Name = "buttonLoginPelajar";
            buttonLoginPelajar.Size = new Size(142, 22);
            buttonLoginPelajar.TabIndex = 18;
            buttonLoginPelajar.Text = "Login Pelajar";
            buttonLoginPelajar.UseVisualStyleBackColor = true;
            buttonLoginPelajar.Click += buttonLoginPelajar_Click;
            // 
            // buttonLoginAdmin
            // 
            buttonLoginAdmin.Location = new Point(414, 204);
            buttonLoginAdmin.Margin = new Padding(3, 2, 3, 2);
            buttonLoginAdmin.Name = "buttonLoginAdmin";
            buttonLoginAdmin.Size = new Size(142, 22);
            buttonLoginAdmin.TabIndex = 17;
            buttonLoginAdmin.Text = "Login Admin";
            buttonLoginAdmin.UseVisualStyleBackColor = true;
            buttonLoginAdmin.Click += buttonLoginAdmin_Click;
            // 
            // labelOutput
            // 
            labelOutput.AutoSize = true;
            labelOutput.Location = new Point(388, 236);
            labelOutput.Name = "labelOutput";
            labelOutput.Size = new Size(0, 15);
            labelOutput.TabIndex = 26;
            labelOutput.Click += label2_Click;
            // 
            // LoginAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(labelOutput);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxUsername);
            Controls.Add(label1);
            Controls.Add(textBoxPassword);
            Controls.Add(buttonLoginPelajar);
            Controls.Add(buttonLoginAdmin);
            Margin = new Padding(3, 2, 3, 2);
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