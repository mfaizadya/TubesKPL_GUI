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
            buttonGoToQuestions = new Button();
            buttonLogOut = new Button();
            listBox1 = new ListBox();
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
            labelNama.Click += labelNama_Click;
            // 
            // buttonReviewAttempt
            // 
            buttonReviewAttempt.Location = new Point(538, 307);
            buttonReviewAttempt.Margin = new Padding(5, 6, 5, 6);
            buttonReviewAttempt.Name = "buttonReviewAttempt";
            buttonReviewAttempt.Size = new Size(212, 50);
            buttonReviewAttempt.TabIndex = 4;
            buttonReviewAttempt.Text = "Review Attempt";
            buttonReviewAttempt.UseVisualStyleBackColor = true;
            buttonReviewAttempt.Click += buttonReviewAttempt_Click;
            // 
            // buttonGoToQuestions
            // 
            buttonGoToQuestions.Location = new Point(328, 194);
            buttonGoToQuestions.Margin = new Padding(5, 6, 5, 6);
            buttonGoToQuestions.Name = "buttonGoToQuestions";
            buttonGoToQuestions.Size = new Size(200, 50);
            buttonGoToQuestions.TabIndex = 5;
            buttonGoToQuestions.Text = "Go To Questions";
            buttonGoToQuestions.UseVisualStyleBackColor = true;
            buttonGoToQuestions.Click += button1_Click;
            // 
            // buttonLogOut
            // 
            buttonLogOut.Location = new Point(538, 366);
            buttonLogOut.Name = "buttonLogOut";
            buttonLogOut.Size = new Size(212, 46);
            buttonLogOut.TabIndex = 6;
            buttonLogOut.Text = "Log Out";
            buttonLogOut.UseVisualStyleBackColor = true;
            buttonLogOut.Click += button1_Click_1;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(47, 85);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(240, 324);
            listBox1.TabIndex = 7;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // MenuPelajar
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(buttonLogOut);
            Controls.Add(buttonGoToQuestions);
            Controls.Add(buttonReviewAttempt);
            Controls.Add(labelNama);
            Name = "MenuPelajar";
            Text = "MenuPelajar";
            Load += MenuPelajar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNama;
        private Button buttonReviewAttempt;
        private Button buttonGoToQuestions;
        private Button buttonLogOut;
        private ListBox listBox1;
    }
}