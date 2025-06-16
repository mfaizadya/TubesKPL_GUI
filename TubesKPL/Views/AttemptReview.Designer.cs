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
            buttonDetail = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAttempt).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewAttempt
            // 
            dataGridViewAttempt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAttempt.Location = new Point(11, 16);
            dataGridViewAttempt.Margin = new Padding(3, 2, 3, 2);
            dataGridViewAttempt.Name = "dataGridViewAttempt";
            dataGridViewAttempt.RowHeadersWidth = 51;
            dataGridViewAttempt.Size = new Size(660, 303);
            dataGridViewAttempt.TabIndex = 0;
            // 
            // ButtonBack
            // 
            ButtonBack.Location = new Point(688, 285);
            ButtonBack.Margin = new Padding(3, 2, 3, 2);
            ButtonBack.Name = "ButtonBack";
            ButtonBack.Size = new Size(103, 29);
            ButtonBack.TabIndex = 1;
            ButtonBack.Text = "Kembali";
            ButtonBack.UseVisualStyleBackColor = true;
            ButtonBack.Click += ButtonBack_Click;
            // 
            // buttonDetail
            // 
            buttonDetail.Location = new Point(688, 243);
            buttonDetail.Name = "buttonDetail";
            buttonDetail.Size = new Size(103, 23);
            buttonDetail.TabIndex = 0;
            buttonDetail.Text = "Detail";
            buttonDetail.Click += ButtonDetail_Click;
            // 
            // AttemptReview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 359);
            Controls.Add(ButtonBack);
            Controls.Add(dataGridViewAttempt);
            Controls.Add(buttonDetail);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AttemptReview";
            Text = "AttemptReview";
            Load += AttemptReview_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAttempt).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewAttempt;
        private Button ButtonBack;
        private Button buttonDetail;
    }
}