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
            ButtonBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAttempt).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewAttempt
            // 
            dataGridViewAttempt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAttempt.Location = new Point(20, 34);
            dataGridViewAttempt.Margin = new Padding(5);
            dataGridViewAttempt.Name = "dataGridViewAttempt";
            dataGridViewAttempt.RowHeadersWidth = 51;
            dataGridViewAttempt.Size = new Size(1226, 646);
            dataGridViewAttempt.TabIndex = 0;
            // 
            // ButtonBack
            // 
            ButtonBack.Location = new Point(1278, 607);
            ButtonBack.Margin = new Padding(5);
            ButtonBack.Name = "ButtonBack";
            ButtonBack.Size = new Size(192, 62);
            ButtonBack.TabIndex = 1;
            ButtonBack.Text = "Kembali";
            ButtonBack.UseVisualStyleBackColor = true;
            ButtonBack.Click += ButtonBack_Click;
            // 
            // AttemptReview
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1494, 720);
            Controls.Add(ButtonBack);
            Controls.Add(dataGridViewAttempt);
            Margin = new Padding(5);
            Name = "AttemptReview";
            Text = "AttemptReview";
            Load += AttemptReview_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAttempt).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewAttempt;
        private Button ButtonBack;
    }
}