namespace TubesKPL
{
    partial class MenuPelajar
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
            labelNama = new Label();
            SuspendLayout();
            // 
            // labelNama
            // 
            labelNama.AutoSize = true;
            labelNama.Location = new Point(47, 35);
            labelNama.Name = "labelNama";
            labelNama.Size = new Size(133, 32);
            labelNama.TabIndex = 0;
            labelNama.Text = "LabelNama";
            // 
            // MenuPelajar
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelNama);
            Name = "MenuPelajar";
            Text = "MenuPelajar";
            Load += MenuPelajar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNama;
    }
}