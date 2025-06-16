namespace TubesKPL.Views
{
    partial class AttemptDetailPelajar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dataGridViewDetail;

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
            dataGridViewDetail = new DataGridView();
            back = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDetail).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewDetail
            // 
            dataGridViewDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDetail.Location = new Point(12, 12);
            dataGridViewDetail.Name = "dataGridViewDetail";
            dataGridViewDetail.Size = new Size(760, 350);
            dataGridViewDetail.TabIndex = 0;
            // 
            // back
            // 
            back.Location = new Point(697, 404);
            back.Name = "back";
            back.Size = new Size(75, 23);
            back.TabIndex = 1;
            back.Text = "Kembali";
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click;
            // 
            // AttemptDetailPelajar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(back);
            Controls.Add(dataGridViewDetail);
            Name = "AttemptDetailPelajar";
            Text = "Detail Attempt";
            Load += AttemptDetailPelajar_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewDetail).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button back;
    }
}
