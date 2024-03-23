namespace Online_Examination_System
{
    partial class InstructorNavigationArea
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
            Ques_Btn = new Button();
            logoutBtn = new Button();
            coursesBtn = new Button();
            ProfileBtn = new Button();
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
            panel1.Controls.Add(Ques_Btn);
            panel1.Controls.Add(logoutBtn);
            panel1.Controls.Add(coursesBtn);
            panel1.Controls.Add(ProfileBtn);
            panel1.Controls.Add(panelLogo);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 585);
            panel1.TabIndex = 4;
            // 
            // Ques_Btn
            // 
            Ques_Btn.Dock = DockStyle.Top;
            Ques_Btn.FlatAppearance.BorderSize = 0;
            Ques_Btn.FlatStyle = FlatStyle.Flat;
            Ques_Btn.ForeColor = Color.Gainsboro;
            Ques_Btn.Location = new Point(0, 200);
            Ques_Btn.Name = "Ques_Btn";
            Ques_Btn.Size = new Size(220, 60);
            Ques_Btn.TabIndex = 8;
            Ques_Btn.Text = "Questions";
            Ques_Btn.UseVisualStyleBackColor = true;
            Ques_Btn.Click += Ques_Btn_Click;
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
            coursesBtn.Text = "Courses";
            coursesBtn.UseVisualStyleBackColor = true;
            coursesBtn.Click += coursesBtn_Click;
            // 
            // ProfileBtn
            // 
            ProfileBtn.Dock = DockStyle.Top;
            ProfileBtn.FlatAppearance.BorderSize = 0;
            ProfileBtn.FlatStyle = FlatStyle.Flat;
            ProfileBtn.ForeColor = Color.Gainsboro;
            ProfileBtn.Location = new Point(0, 80);
            ProfileBtn.Name = "ProfileBtn";
            ProfileBtn.Size = new Size(220, 60);
            ProfileBtn.TabIndex = 1;
            ProfileBtn.Text = "Profile";
            ProfileBtn.UseVisualStyleBackColor = true;
            ProfileBtn.Click += ProfileBtn_Click;
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
            panelDesktopPanel.BackColor = Color.FromArgb(51, 51, 76);
            panelDesktopPanel.Controls.Add(panel3);
            panelDesktopPanel.Dock = DockStyle.Fill;
            panelDesktopPanel.Location = new Point(0, 0);
            panelDesktopPanel.Name = "panelDesktopPanel";
            panelDesktopPanel.Size = new Size(1215, 585);
            panelDesktopPanel.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Lavender;
            panel3.Location = new Point(235, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(968, 561);
            panel3.TabIndex = 4;
            // 
            // InstructorNavigationArea
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1215, 585);
            Controls.Add(panel1);
            Controls.Add(panelDesktopPanel);
            Name = "InstructorNavigationArea";
            Text = "InstructorNavigationArea";
            panel1.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            panelDesktopPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button Ques_Btn;
        private Button logoutBtn;
        private Button coursesBtn;
        private Button ProfileBtn;
        private Panel panelLogo;
        private Label title;
        private Panel panelDesktopPanel;
        private Panel panel3;
    }
}