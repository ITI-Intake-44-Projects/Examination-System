namespace Online_Examination_System
{
    partial class studentDashboard
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
            profileBtn = new Button();
            requestExamBtn = new Button();
            coursesBtn = new Button();
            prevExamsBtn = new Button();
            logoutBtn = new Button();
            label1 = new Label();
            courses_box = new ComboBox();
            SuspendLayout();
            // 
            // profileBtn
            // 
            profileBtn.Font = new Font("Segoe UI", 9F);
            profileBtn.Location = new Point(25, 79);
            profileBtn.Name = "profileBtn";
            profileBtn.Size = new Size(118, 25);
            profileBtn.TabIndex = 0;
            profileBtn.Text = "My Profile";
            profileBtn.UseVisualStyleBackColor = true;
            profileBtn.Click += profileBtn_Click;
            // 
            // requestExamBtn
            // 
            requestExamBtn.Font = new Font("Segoe UI", 9F);
            requestExamBtn.Location = new Point(25, 128);
            requestExamBtn.Name = "requestExamBtn";
            requestExamBtn.Size = new Size(118, 25);
            requestExamBtn.TabIndex = 1;
            requestExamBtn.Text = "Request an Exam";
            requestExamBtn.UseVisualStyleBackColor = true;
            requestExamBtn.Click += requestExamBtn_Click;
            // 
            // coursesBtn
            // 
            coursesBtn.BackColor = SystemColors.Control;
            coursesBtn.FlatAppearance.BorderColor = Color.AliceBlue;
            coursesBtn.FlatAppearance.BorderSize = 0;
            coursesBtn.FlatStyle = FlatStyle.System;
            coursesBtn.Font = new Font("Segoe UI", 9F);
            coursesBtn.Location = new Point(175, 79);
            coursesBtn.Name = "coursesBtn";
            coursesBtn.Size = new Size(121, 25);
            coursesBtn.TabIndex = 2;
            coursesBtn.Text = "My Courses";
            coursesBtn.UseVisualStyleBackColor = false;
            coursesBtn.Click += coursesBtn_Click;
            // 
            // prevExamsBtn
            // 
            prevExamsBtn.Font = new Font("Segoe UI", 9F);
            prevExamsBtn.Location = new Point(25, 175);
            prevExamsBtn.Name = "prevExamsBtn";
            prevExamsBtn.Size = new Size(118, 25);
            prevExamsBtn.TabIndex = 3;
            prevExamsBtn.Text = "Previous Exams";
            prevExamsBtn.UseVisualStyleBackColor = true;
            prevExamsBtn.Click += prevExamsBtn_Click;
            // 
            // logoutBtn
            // 
            logoutBtn.Font = new Font("Segoe UI", 9F);
            logoutBtn.Location = new Point(175, 175);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(121, 25);
            logoutBtn.TabIndex = 4;
            logoutBtn.Text = "Logout";
            logoutBtn.UseVisualStyleBackColor = true;
            logoutBtn.Click += logoutBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 15F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(72, 22);
            label1.Name = "label1";
            label1.Size = new Size(186, 24);
            label1.TabIndex = 5;
            label1.Text = "Student Dashboard";
            // 
            // courses_box
            // 
            courses_box.FormattingEnabled = true;
            courses_box.Location = new Point(175, 128);
            courses_box.Name = "courses_box";
            courses_box.Size = new Size(121, 23);
            courses_box.TabIndex = 6;
            courses_box.Text = "     Choose Course";
            // 
            // studentDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bkg;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(342, 250);
            Controls.Add(courses_box);
            Controls.Add(label1);
            Controls.Add(logoutBtn);
            Controls.Add(prevExamsBtn);
            Controls.Add(coursesBtn);
            Controls.Add(requestExamBtn);
            Controls.Add(profileBtn);
            DoubleBuffered = true;
            Name = "studentDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "studentDashboard";
            Load += studentDashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button profileBtn;
        private Button requestExamBtn;
        private Button coursesBtn;
        private Button prevExamsBtn;
        private Button logoutBtn;
        private Label label1;
        private ComboBox courses_box;
    }
}