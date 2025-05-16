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
            buttonReviewAttempt = new Button();
            SuspendLayout();
            // 
            // labelNama
            // 
            labelNama.AutoSize = true;
            labelNama.Location = new Point(29, 22);
            labelNama.Margin = new Padding(2, 0, 2, 0);
            labelNama.Name = "labelNama";
            labelNama.Size = new Size(85, 20);
            labelNama.TabIndex = 0;
            labelNama.Text = "LabelNama";
            labelNama.Click += labelNama_Click;
            // 
            // buttonReviewAttempt
            // 
            buttonReviewAttempt.Location = new Point(165, 139);
            buttonReviewAttempt.Margin = new Padding(3, 4, 3, 4);
            buttonReviewAttempt.Name = "buttonReviewAttempt";
            buttonReviewAttempt.Size = new Size(153, 31);
            buttonReviewAttempt.TabIndex = 4;
            buttonReviewAttempt.Text = "Review Attempt";
            buttonReviewAttempt.UseVisualStyleBackColor = true;
            buttonReviewAttempt.Click += buttonReviewAttempt_Click;
            // 
            // MenuPelajar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 281);
            Controls.Add(buttonReviewAttempt);
            Controls.Add(labelNama);
            Margin = new Padding(2);
            Name = "MenuPelajar";
            Text = "MenuPelajar";
            Load += MenuPelajar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNama;
        private Button buttonReviewAttempt;
    }
}