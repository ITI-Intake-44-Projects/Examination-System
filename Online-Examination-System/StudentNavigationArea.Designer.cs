namespace Online_Examination_System
{
    partial class StudentNavigationArea
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
            panel1 = new Panel();
            requestExamBtn = new Button();
            courses_box = new ComboBox();
            logoutBtn = new Button();
            PreviousExamsBtn = new Button();
            coursesBtn = new Button();
            profileBtn = new Button();
            panelLogo = new Panel();
            title = new Label();
            panelDesktopPanel = new Panel();
            panel1.SuspendLayout();
            panelLogo.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 51, 76);
            panel1.Controls.Add(requestExamBtn);
            panel1.Controls.Add(courses_box);
            panel1.Controls.Add(logoutBtn);
            panel1.Controls.Add(PreviousExamsBtn);
            panel1.Controls.Add(coursesBtn);
            panel1.Controls.Add(profileBtn);
            panel1.Controls.Add(panelLogo);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 585);
            panel1.TabIndex = 0;
            // 
            // requestExamBtn
            // 
            requestExamBtn.FlatAppearance.BorderSize = 0;
            requestExamBtn.FlatStyle = FlatStyle.Flat;
            requestExamBtn.ForeColor = Color.Gainsboro;
            requestExamBtn.Location = new Point(3, 224);
            requestExamBtn.Name = "requestExamBtn";
            requestExamBtn.Size = new Size(101, 60);
            requestExamBtn.TabIndex = 8;
            requestExamBtn.Text = "Request Exam";
            requestExamBtn.UseVisualStyleBackColor = true;
            requestExamBtn.Click += requestExamBtn_Click_1;
            // 
            // courses_box
            // 
            courses_box.BackColor = Color.White;
            courses_box.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            courses_box.FormattingEnabled = true;
            courses_box.Location = new Point(100, 245);
            courses_box.Name = "courses_box";
            courses_box.Size = new Size(114, 21);
            courses_box.TabIndex = 9;
            courses_box.Text = "  Choose Course";
            // 
            // logoutBtn
            // 
            logoutBtn.Dock = DockStyle.Bottom;
            logoutBtn.FlatAppearance.BorderSize = 0;
            logoutBtn.FlatStyle = FlatStyle.Flat;
            logoutBtn.ForeColor = Color.Gainsboro;
            logoutBtn.Location = new Point(0, 526);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(220, 59);
            logoutBtn.TabIndex = 7;
            logoutBtn.Text = "Logout";
            logoutBtn.UseVisualStyleBackColor = true;
            logoutBtn.Click += logoutBtn_Click_1;
            // 
            // PreviousExamsBtn
            // 
            PreviousExamsBtn.FlatAppearance.BorderSize = 0;
            PreviousExamsBtn.FlatStyle = FlatStyle.Flat;
            PreviousExamsBtn.ForeColor = Color.Gainsboro;
            PreviousExamsBtn.Location = new Point(0, 290);
            PreviousExamsBtn.Name = "PreviousExamsBtn";
            PreviousExamsBtn.Size = new Size(220, 54);
            PreviousExamsBtn.TabIndex = 3;
            PreviousExamsBtn.Text = "Previous Exams";
            PreviousExamsBtn.UseVisualStyleBackColor = true;
            PreviousExamsBtn.Click += PreviousExamsBtn_Click;
            // 
            // coursesBtn
            // 
            coursesBtn.FlatAppearance.BorderSize = 0;
            coursesBtn.FlatStyle = FlatStyle.Flat;
            coursesBtn.ForeColor = Color.Gainsboro;
            coursesBtn.Location = new Point(0, 158);
            coursesBtn.Name = "coursesBtn";
            coursesBtn.Size = new Size(220, 60);
            coursesBtn.TabIndex = 2;
            coursesBtn.Text = "My Courses";
            coursesBtn.UseVisualStyleBackColor = true;
            coursesBtn.Click += coursesBtn_Click;
            // 
            // profileBtn
            // 
            profileBtn.Dock = DockStyle.Top;
            profileBtn.FlatAppearance.BorderSize = 0;
            profileBtn.FlatStyle = FlatStyle.Flat;
            profileBtn.ForeColor = Color.Gainsboro;
            profileBtn.Location = new Point(0, 80);
            profileBtn.Name = "profileBtn";
            profileBtn.Size = new Size(220, 60);
            profileBtn.TabIndex = 1;
            profileBtn.Text = "Profile";
            profileBtn.UseVisualStyleBackColor = true;
            profileBtn.Click += profileBtn_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            panelLogo.Controls.Add(title);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Font = new Font("Segoe UI", 15F);
            panelLogo.ForeColor = SystemColors.Control;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 80);
            panelLogo.TabIndex = 0;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Location = new Point(17, 29);
            title.Name = "title";
            title.Size = new Size(186, 28);
            title.TabIndex = 0;
            title.Text = "Examination System";
            // 
            // panelDesktopPanel
            // 
            panelDesktopPanel.Dock = DockStyle.Fill;
            panelDesktopPanel.Location = new Point(220, 0);
            panelDesktopPanel.Name = "panelDesktopPanel";
            panelDesktopPanel.Size = new Size(916, 585);
            panelDesktopPanel.TabIndex = 1;
            // 
            // StudentNavigationArea
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1136, 585);
            Controls.Add(panelDesktopPanel);
            Controls.Add(panel1);
            Name = "StudentNavigationArea";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentNavigationArea";
            Load += StudentNavigationArea_Load;
            panel1.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button profileBtn;
        private Panel panelLogo;
        private Button coursesBtn;
        private Label title;
        private Panel panelDesktopPanel;
        private Button logoutBtn;
        private Button PreviousExamsBtn;
        private ComboBox courses_box;
        private Button requestExamBtn;
    }
}