namespace TubesKPL
{
    partial class AttemptReview
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
            dataGridViewAttempt = new DataGridView();
            buttonBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAttempt).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewAttempt
            // 
            dataGridViewAttempt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAttempt.Location = new Point(12, 21);
            dataGridViewAttempt.Name = "dataGridViewAttempt";
            dataGridViewAttempt.RowHeadersWidth = 51;
            dataGridViewAttempt.Size = new Size(612, 404);
            dataGridViewAttempt.TabIndex = 0;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(656, 348);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(118, 39);
            buttonBack.TabIndex = 1;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // AttemptReview
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonBack);
            Controls.Add(dataGridViewAttempt);
            Name = "AttemptReview";
            Text = "AttemptReview";
            Load += AttemptReview_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAttempt).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewAttempt;
        private Button buttonBack;
    }
}