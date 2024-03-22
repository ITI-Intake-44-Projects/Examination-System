namespace Online_Examination_System
{
    partial class StudentCourses
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
            coursesDgv = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)coursesDgv).BeginInit();
            SuspendLayout();
            // 
            // coursesDgv
            // 
            coursesDgv.BackgroundColor = SystemColors.ActiveCaption;
            coursesDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            coursesDgv.Location = new Point(132, 95);
            coursesDgv.Name = "coursesDgv";
            coursesDgv.Size = new Size(628, 292);
            coursesDgv.TabIndex = 0;
            // 
            // StudentCourses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 51, 76);
            ClientSize = new Size(900, 546);
            Controls.Add(coursesDgv);
            Name = "StudentCourses";
            Text = "StudentCourses";
            Load += StudentCourses_Load;
            ((System.ComponentModel.ISupportInitialize)coursesDgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView coursesDgv;
    }
}