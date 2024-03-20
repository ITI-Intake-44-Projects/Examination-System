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
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(24, 76);
            label2.Name = "label2";
            label2.Size = new Size(77, 18);
            label2.TabIndex = 2;
            label2.Text = "Password";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(21, 35);
            label1.Name = "label1";
            label1.Size = new Size(80, 18);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // password_txt
            // 
            password_txt.Location = new Point(130, 76);
            password_txt.Name = "password_txt";
            password_txt.PasswordChar = '*';
            password_txt.PlaceholderText = "Password";
            password_txt.Size = new Size(125, 23);
            password_txt.TabIndex = 3;
            // 
            // username_txt
            // 
            username_txt.Location = new Point(130, 30);
            username_txt.Name = "username_txt";
            username_txt.PlaceholderText = "Username";
            username_txt.Size = new Size(125, 23);
            username_txt.TabIndex = 1;
            // 
            // Login_btn
            // 
            Login_btn.BackColor = Color.Transparent;
            Login_btn.FlatAppearance.BorderSize = 0;
            Login_btn.FlatStyle = FlatStyle.Flat;
            Login_btn.Font = new Font("Arial", 12.25F, FontStyle.Bold);
            Login_btn.ForeColor = Color.White;
            Login_btn.Location = new Point(124, 235);
            Login_btn.Name = "Login_btn";
            Login_btn.Size = new Size(90, 30);
            Login_btn.TabIndex = 6;
            Login_btn.Text = "Login";
            Login_btn.UseVisualStyleBackColor = false;
            Login_btn.Click += Login_btn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(40, 158);
            label3.Name = "label3";
            label3.Size = new Size(41, 18);
            label3.TabIndex = 4;
            label3.Text = "Role";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(instructor_rbtn);
            panel1.Controls.Add(supervisor_rbtn);
            panel1.Controls.Add(student_rbtn);
            panel1.Location = new Point(130, 115);
            panel1.Name = "panel1";
            panel1.Size = new Size(125, 101);
            panel1.TabIndex = 5;
            // 
            // instructor_rbtn
            // 
            instructor_rbtn.AutoSize = true;
            instructor_rbtn.Font = new Font("Arial", 9.25F, FontStyle.Bold);
            instructor_rbtn.ForeColor = Color.White;
            instructor_rbtn.Location = new Point(3, 79);
            instructor_rbtn.Name = "instructor_rbtn";
            instructor_rbtn.Size = new Size(84, 20);
            instructor_rbtn.TabIndex = 2;
            instructor_rbtn.TabStop = true;
            instructor_rbtn.Text = "Instructor";
            instructor_rbtn.UseVisualStyleBackColor = true;
            instructor_rbtn.CheckedChanged += student_rbtn_CheckedChanged;
            // 
            // supervisor_rbtn
            // 
            supervisor_rbtn.AutoSize = true;
            supervisor_rbtn.Font = new Font("Arial", 9.25F, FontStyle.Bold);
            supervisor_rbtn.ForeColor = Color.White;
            supervisor_rbtn.Location = new Point(3, 43);
            supervisor_rbtn.Name = "supervisor_rbtn";
            supervisor_rbtn.Size = new Size(93, 20);
            supervisor_rbtn.TabIndex = 1;
            supervisor_rbtn.TabStop = true;
            supervisor_rbtn.Text = "Supervisor";
            supervisor_rbtn.UseVisualStyleBackColor = true;
            supervisor_rbtn.CheckedChanged += student_rbtn_CheckedChanged;
            // 
            // student_rbtn
            // 
            student_rbtn.AutoSize = true;
            student_rbtn.Font = new Font("Arial", 9.25F, FontStyle.Bold);
            student_rbtn.ForeColor = Color.White;
            student_rbtn.Location = new Point(3, 6);
            student_rbtn.Name = "student_rbtn";
            student_rbtn.Size = new Size(74, 20);
            student_rbtn.TabIndex = 0;
            student_rbtn.TabStop = true;
            student_rbtn.Text = "Student";
            student_rbtn.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Green;
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(53, 288);
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
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.bkg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(332, 312);
            Controls.Add(linkLabel1);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(password_txt);
            Controls.Add(username_txt);
            Controls.Add(Login_btn);
            DoubleBuffered = true;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
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