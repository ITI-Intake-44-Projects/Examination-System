namespace Online_Examination_System
{
    partial class SuperVisorNavigationArea
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
            St_Answers_Btn = new Button();
            St_Track_btn = new Button();
            St_Grades_btn = new Button();
            ExamBtn = new Button();
            logoutBtn = new Button();
            coursesBtn = new Button();
            InsBtn = new Button();
            panelLogo = new Panel();
            title = new Label();
            panelDesktopPanel = new Panel();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panelLogo.SuspendLayout();
            panelDesktopPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 51, 76);
            panel1.Controls.Add(St_Answers_Btn);
            panel1.Controls.Add(St_Track_btn);
            panel1.Controls.Add(St_Grades_btn);
            panel1.Controls.Add(ExamBtn);
            panel1.Controls.Add(logoutBtn);
            panel1.Controls.Add(coursesBtn);
            panel1.Controls.Add(InsBtn);
            panel1.Controls.Add(panelLogo);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 585);
            panel1.TabIndex = 2;
            // 
            // St_Answers_Btn
            // 
            St_Answers_Btn.Dock = DockStyle.Top;
            St_Answers_Btn.FlatAppearance.BorderSize = 0;
            St_Answers_Btn.FlatStyle = FlatStyle.Flat;
            St_Answers_Btn.ForeColor = Color.Gainsboro;
            St_Answers_Btn.Location = new Point(0, 380);
            St_Answers_Btn.Name = "St_Answers_Btn";
            St_Answers_Btn.Size = new Size(220, 60);
            St_Answers_Btn.TabIndex = 11;
            St_Answers_Btn.Text = "Student Answers Report";
            St_Answers_Btn.UseVisualStyleBackColor = true;
            St_Answers_Btn.Click += St_Answers_Btn_Click;
            // 
            // St_Track_btn
            // 
            St_Track_btn.Dock = DockStyle.Top;
            St_Track_btn.FlatAppearance.BorderSize = 0;
            St_Track_btn.FlatStyle = FlatStyle.Flat;
            St_Track_btn.ForeColor = Color.Gainsboro;
            St_Track_btn.Location = new Point(0, 320);
            St_Track_btn.Name = "St_Track_btn";
            St_Track_btn.Size = new Size(220, 60);
            St_Track_btn.TabIndex = 10;
            St_Track_btn.Text = "Student Track Report";
            St_Track_btn.UseVisualStyleBackColor = true;
            St_Track_btn.Click += St_Track_btn_Click;
            // 
            // St_Grades_btn
            // 
            St_Grades_btn.Dock = DockStyle.Top;
            St_Grades_btn.FlatAppearance.BorderSize = 0;
            St_Grades_btn.FlatStyle = FlatStyle.Flat;
            St_Grades_btn.ForeColor = Color.Gainsboro;
            St_Grades_btn.Location = new Point(0, 260);
            St_Grades_btn.Name = "St_Grades_btn";
            St_Grades_btn.Size = new Size(220, 60);
            St_Grades_btn.TabIndex = 9;
            St_Grades_btn.Text = "Student Grades Report";
            St_Grades_btn.UseVisualStyleBackColor = true;
            St_Grades_btn.Click += St_Grades_btn_Click;
            // 
            // ExamBtn
            // 
            ExamBtn.Dock = DockStyle.Top;
            ExamBtn.FlatAppearance.BorderSize = 0;
            ExamBtn.FlatStyle = FlatStyle.Flat;
            ExamBtn.ForeColor = Color.Gainsboro;
            ExamBtn.Location = new Point(0, 200);
            ExamBtn.Name = "ExamBtn";
            ExamBtn.Size = new Size(220, 60);
            ExamBtn.TabIndex = 8;
            ExamBtn.Text = "Exam Report";
            ExamBtn.UseVisualStyleBackColor = true;
            ExamBtn.Click += ExamBtn_Click;
            // 
            // logoutBtn
            // 
            logoutBtn.Dock = DockStyle.Bottom;
            logoutBtn.FlatAppearance.BorderSize = 0;
            logoutBtn.FlatStyle = FlatStyle.Flat;
            logoutBtn.ForeColor = Color.Gainsboro;
            logoutBtn.Location = new Point(0, 525);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(220, 60);
            logoutBtn.TabIndex = 7;
            logoutBtn.Text = "Logout";
            logoutBtn.UseVisualStyleBackColor = true;
            logoutBtn.Click += logoutBtn_Click;
            // 
            // coursesBtn
            // 
            coursesBtn.Dock = DockStyle.Top;
            coursesBtn.FlatAppearance.BorderSize = 0;
            coursesBtn.FlatStyle = FlatStyle.Flat;
            coursesBtn.ForeColor = Color.Gainsboro;
            coursesBtn.Location = new Point(0, 140);
            coursesBtn.Name = "coursesBtn";
            coursesBtn.Size = new Size(220, 60);
            coursesBtn.TabIndex = 2;
            coursesBtn.Text = "Course Topics Report";
            coursesBtn.UseVisualStyleBackColor = true;
            coursesBtn.Click += coursesBtn_Click;
            // 
            // InsBtn
            // 
            InsBtn.Dock = DockStyle.Top;
            InsBtn.FlatAppearance.BorderSize = 0;
            InsBtn.FlatStyle = FlatStyle.Flat;
            InsBtn.ForeColor = Color.Gainsboro;
            InsBtn.Location = new Point(0, 80);
            InsBtn.Name = "InsBtn";
            InsBtn.Size = new Size(220, 60);
            InsBtn.TabIndex = 1;
            InsBtn.Text = "Instructor Report";
            InsBtn.UseVisualStyleBackColor = true;
            InsBtn.Click += InsBtn_Click;
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
            panelDesktopPanel.AutoScroll = true;
            panelDesktopPanel.AutoSize = true;
            panelDesktopPanel.Controls.Add(panel3);
            panelDesktopPanel.Dock = DockStyle.Fill;
            panelDesktopPanel.Location = new Point(0, 0);
            panelDesktopPanel.Name = "panelDesktopPanel";
            panelDesktopPanel.Size = new Size(1215, 585);
            panelDesktopPanel.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Location = new Point(264, 29);
            panel3.Name = "panel3";
            panel3.Size = new Size(910, 534);
            panel3.TabIndex = 4;
            // 
            // SuperVisorNavigationArea
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1215, 585);
            Controls.Add(panel1);
            Controls.Add(panelDesktopPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SuperVisorNavigationArea";
            Text = "SuperVisorNavigationArea";
            panel1.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            panelDesktopPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button ExamBtn;
        private Button logoutBtn;
        private Button coursesBtn;
        private Button InsBtn;
        private Panel panelLogo;
        private Label title;
        private Panel panelDesktopPanel;
        private Button St_Grades_btn;
        private Button St_Track_btn;
        private Button St_Answers_Btn;
        private Panel panel3;
    }
}