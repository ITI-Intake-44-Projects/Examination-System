namespace Online_Examination_System
{
    partial class instructorDashboard
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
            label1 = new Label();
            logoutBtn = new Button();
            profileBtn = new Button();
            coursesBtn = new Button();
            questionBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 15F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(83, 43);
            label1.Name = "label1";
            label1.Size = new Size(209, 24);
            label1.TabIndex = 8;
            label1.Text = "Instructor Dashboard";
            // 
            // logoutBtn
            // 
            logoutBtn.Font = new Font("Segoe UI", 9F);
            logoutBtn.Location = new Point(129, 207);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(105, 25);
            logoutBtn.TabIndex = 7;
            logoutBtn.Text = "Logout";
            logoutBtn.UseVisualStyleBackColor = true;
            logoutBtn.Click += logoutBtn_Click;
            // 
            // profileBtn
            // 
            profileBtn.Font = new Font("Segoe UI", 9F);
            profileBtn.Location = new Point(12, 102);
            profileBtn.Name = "profileBtn";
            profileBtn.Size = new Size(123, 35);
            profileBtn.TabIndex = 6;
            profileBtn.Text = "My Profile";
            profileBtn.UseVisualStyleBackColor = true;
            profileBtn.Click += profileBtn_Click;
            // 
            // coursesBtn
            // 
            coursesBtn.Font = new Font("Segoe UI", 9F);
            coursesBtn.Location = new Point(222, 102);
            coursesBtn.Name = "coursesBtn";
            coursesBtn.Size = new Size(123, 35);
            coursesBtn.TabIndex = 9;
            coursesBtn.Text = "My Courses";
            coursesBtn.UseVisualStyleBackColor = true;
            coursesBtn.Click += coursesBtn_Click;
            // 
            // questionBtn
            // 
            questionBtn.Font = new Font("Segoe UI", 9F);
            questionBtn.Location = new Point(118, 150);
            questionBtn.Name = "questionBtn";
            questionBtn.Size = new Size(123, 35);
            questionBtn.TabIndex = 10;
            questionBtn.Text = "Questions";
            questionBtn.UseVisualStyleBackColor = true;
            questionBtn.Click += questionBtn_Click;
            // 
            // instructorDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 241);
            Controls.Add(questionBtn);
            Controls.Add(coursesBtn);
            Controls.Add(label1);
            Controls.Add(logoutBtn);
            Controls.Add(profileBtn);
            Name = "instructorDashboard";
            Text = "Instractor Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button logoutBtn;
        private Button profileBtn;
        private Button coursesBtn;
        private Button questionBtn;
    }
}