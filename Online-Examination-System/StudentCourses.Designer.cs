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
            logoutBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)coursesDgv).BeginInit();
            SuspendLayout();
            // 
            // coursesDgv
            // 
            coursesDgv.BackgroundColor = SystemColors.ActiveCaption;
            coursesDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            coursesDgv.Location = new Point(12, 12);
            coursesDgv.Name = "coursesDgv";
            coursesDgv.Size = new Size(346, 252);
            coursesDgv.TabIndex = 0;
            // 
            // logoutBtn
            // 
            logoutBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logoutBtn.Location = new Point(125, 271);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(110, 29);
            logoutBtn.TabIndex = 1;
            logoutBtn.Text = "Logout";
            logoutBtn.UseVisualStyleBackColor = true;
            logoutBtn.Click += logoutBtn_Click;
            // 
            // StudentCourses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 312);
            Controls.Add(logoutBtn);
            Controls.Add(coursesDgv);
            Name = "StudentCourses";
            Text = "StudentCourses";
            Load += StudentCourses_Load;
            ((System.ComponentModel.ISupportInitialize)coursesDgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView coursesDgv;
        private Button logoutBtn;
    }
}