namespace Online_Examination_System
{
    partial class Login
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
            label2 = new Label();
            label1 = new Label();
            password_txt = new TextBox();
            username_txt = new TextBox();
            Login_btn = new Button();
            label3 = new Label();
            panel1 = new Panel();
            instructor_rbtn = new RadioButton();
            supervisor_rbtn = new RadioButton();
            student_rbtn = new RadioButton();
            linkLabel1 = new LinkLabel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 76);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 30);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // password_txt
            // 
            password_txt.Location = new Point(130, 76);
            password_txt.Name = "password_txt";
            password_txt.PasswordChar = '*';
            password_txt.PlaceholderText = "Password";
            password_txt.Size = new Size(122, 23);
            password_txt.TabIndex = 3;
            // 
            // username_txt
            // 
            username_txt.Location = new Point(130, 30);
            username_txt.Name = "username_txt";
            username_txt.PlaceholderText = "Username";
            username_txt.Size = new Size(122, 23);
            username_txt.TabIndex = 1;
            // 
            // Login_btn
            // 
            Login_btn.Location = new Point(124, 233);
            Login_btn.Name = "Login_btn";
            Login_btn.Size = new Size(75, 23);
            Login_btn.TabIndex = 6;
            Login_btn.Text = "Login";
            Login_btn.UseVisualStyleBackColor = true;
            Login_btn.Click += Login_btn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 162);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 4;
            label3.Text = "Role";
            // 
            // panel1
            // 
            panel1.Controls.Add(instructor_rbtn);
            panel1.Controls.Add(supervisor_rbtn);
            panel1.Controls.Add(student_rbtn);
            panel1.Location = new Point(130, 115);
            panel1.Name = "panel1";
            panel1.Size = new Size(122, 101);
            panel1.TabIndex = 5;
            // 
            // instructor_rbtn
            // 
            instructor_rbtn.AutoSize = true;
            instructor_rbtn.Location = new Point(3, 79);
            instructor_rbtn.Name = "instructor_rbtn";
            instructor_rbtn.Size = new Size(76, 19);
            instructor_rbtn.TabIndex = 2;
            instructor_rbtn.TabStop = true;
            instructor_rbtn.Text = "Instructor";
            instructor_rbtn.UseVisualStyleBackColor = true;
            instructor_rbtn.CheckedChanged += student_rbtn_CheckedChanged;
            // 
            // supervisor_rbtn
            // 
            supervisor_rbtn.AutoSize = true;
            supervisor_rbtn.Location = new Point(3, 43);
            supervisor_rbtn.Name = "supervisor_rbtn";
            supervisor_rbtn.Size = new Size(80, 19);
            supervisor_rbtn.TabIndex = 1;
            supervisor_rbtn.TabStop = true;
            supervisor_rbtn.Text = "Supervisor";
            supervisor_rbtn.UseVisualStyleBackColor = true;
            supervisor_rbtn.CheckedChanged += student_rbtn_CheckedChanged;
            // 
            // student_rbtn
            // 
            student_rbtn.AutoSize = true;
            student_rbtn.Location = new Point(3, 6);
            student_rbtn.Name = "student_rbtn";
            student_rbtn.Size = new Size(66, 19);
            student_rbtn.TabIndex = 0;
            student_rbtn.TabStop = true;
            student_rbtn.Text = "Student";
            student_rbtn.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(53, 276);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(223, 15);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Don't have an account yet? Sign Up now!";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 312);
            Controls.Add(linkLabel1);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(password_txt);
            Controls.Add(username_txt);
            Controls.Add(Login_btn);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox password_txt;
        private TextBox username_txt;
        private Button Login_btn;
        private Label label3;
        private Panel panel1;
        private RadioButton student_rbtn;
        private RadioButton instructor_rbtn;
        private RadioButton supervisor_rbtn;
        private LinkLabel linkLabel1;
    }
}