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
            PreviousExamsBtn = new Button();
            coursesBtn = new Button();
            profileBtn = new Button();
            panelLogo = new Panel();
            title = new Label();
            panelDesktopPanel = new Panel();
            button1 = new Button();
            logoutBtn = new Button();
            panel1.SuspendLayout();
            panelLogo.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 51, 76);
            panel1.Controls.Add(logoutBtn);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(PreviousExamsBtn);
            panel1.Controls.Add(coursesBtn);
            panel1.Controls.Add(profileBtn);
            panel1.Controls.Add(panelLogo);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 450);
            panel1.TabIndex = 0;
            // 
            // PreviousExamsBtn
            // 
            PreviousExamsBtn.Dock = DockStyle.Top;
            PreviousExamsBtn.FlatAppearance.BorderSize = 0;
            PreviousExamsBtn.FlatStyle = FlatStyle.Flat;
            PreviousExamsBtn.ForeColor = Color.Gainsboro;
            PreviousExamsBtn.Location = new Point(0, 200);
            PreviousExamsBtn.Name = "PreviousExamsBtn";
            PreviousExamsBtn.Size = new Size(220, 60);
            PreviousExamsBtn.TabIndex = 3;
            PreviousExamsBtn.Text = "Previous Exams";
            PreviousExamsBtn.UseVisualStyleBackColor = true;
            PreviousExamsBtn.Click += PreviousExamsBtn_Click;
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
            panelDesktopPanel.Size = new Size(580, 450);
            panelDesktopPanel.TabIndex = 1;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Gainsboro;
            button1.Location = new Point(0, 260);
            button1.Name = "button1";
            button1.Size = new Size(220, 60);
            button1.TabIndex = 6;
            button1.Text = "Request Exam";
            button1.UseVisualStyleBackColor = true;
            // 
            // logoutBtn
            // 
            logoutBtn.Dock = DockStyle.Bottom;
            logoutBtn.FlatAppearance.BorderSize = 0;
            logoutBtn.FlatStyle = FlatStyle.Flat;
            logoutBtn.ForeColor = Color.Gainsboro;
            logoutBtn.Location = new Point(0, 390);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(220, 60);
            logoutBtn.TabIndex = 7;
            logoutBtn.Text = "Logout";
            logoutBtn.UseVisualStyleBackColor = true;
            // 
            // StudentNavigationArea
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelDesktopPanel);
            Controls.Add(panel1);
            Name = "StudentNavigationArea";
            Text = "StudentNavigationArea";
            panel1.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button profileBtn;
        private Panel panelLogo;
        private Button PreviousExamsBtn;
        private Button coursesBtn;
        private Label title;
        private Panel panelDesktopPanel;
        private Button logoutBtn;
        private Button button1;
    }
}