namespace Online_Examination_System
{
    partial class SignUp
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
            nextBtn = new Button();
            label4 = new Label();
            label5 = new Label();
            address_txt = new TextBox();
            firstname_txt = new TextBox();
            lastname_txt = new TextBox();
            label6 = new Label();
            label7 = new Label();
            datePicker = new DateTimePicker();
            label3 = new Label();
            role_cb = new ComboBox();
            label8 = new Label();
            backBtn = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(279, 162);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 13;
            label2.Text = "Birth Date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 162);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 14;
            label1.Text = "Address";
            // 
            // password_txt
            // 
            password_txt.Location = new Point(353, 116);
            password_txt.Name = "password_txt";
            password_txt.PasswordChar = '*';
            password_txt.PlaceholderText = "Password";
            password_txt.Size = new Size(207, 23);
            password_txt.TabIndex = 10;
            // 
            // username_txt
            // 
            username_txt.Location = new Point(353, 72);
            username_txt.Name = "username_txt";
            username_txt.PlaceholderText = "Username";
            username_txt.Size = new Size(207, 23);
            username_txt.TabIndex = 11;
            // 
            // nextBtn
            // 
            nextBtn.Location = new Point(470, 198);
            nextBtn.Name = "nextBtn";
            nextBtn.Size = new Size(90, 27);
            nextBtn.TabIndex = 9;
            nextBtn.Text = "Next";
            nextBtn.UseVisualStyleBackColor = true;
            nextBtn.Click += nextBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(279, 119);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 18;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(279, 80);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 19;
            label5.Text = "Username";
            // 
            // address_txt
            // 
            address_txt.Location = new Point(99, 159);
            address_txt.Name = "address_txt";
            address_txt.PlaceholderText = "Address";
            address_txt.Size = new Size(153, 23);
            address_txt.TabIndex = 17;
            // 
            // firstname_txt
            // 
            firstname_txt.Location = new Point(99, 72);
            firstname_txt.Name = "firstname_txt";
            firstname_txt.PlaceholderText = "First Name";
            firstname_txt.Size = new Size(153, 23);
            firstname_txt.TabIndex = 17;
            // 
            // lastname_txt
            // 
            lastname_txt.Location = new Point(99, 116);
            lastname_txt.Name = "lastname_txt";
            lastname_txt.PlaceholderText = "Last Name";
            lastname_txt.Size = new Size(153, 23);
            lastname_txt.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 78);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 19;
            label6.Text = "First Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 116);
            label7.Name = "label7";
            label7.Size = new Size(63, 15);
            label7.TabIndex = 18;
            label7.Text = "Last Name";
            // 
            // datePicker
            // 
            datePicker.Location = new Point(353, 156);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(207, 23);
            datePicker.TabIndex = 20;
            datePicker.Value = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 201);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 12;
            label3.Text = "Role";
            // 
            // role_cb
            // 
            role_cb.FormattingEnabled = true;
            role_cb.Location = new Point(99, 201);
            role_cb.Name = "role_cb";
            role_cb.Size = new Size(153, 23);
            role_cb.TabIndex = 21;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 20F);
            label8.Location = new Point(242, 9);
            label8.Name = "label8";
            label8.Size = new Size(111, 37);
            label8.TabIndex = 22;
            label8.Text = "Sign Up";
            // 
            // backBtn
            // 
            backBtn.Location = new Point(353, 197);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(90, 27);
            backBtn.TabIndex = 23;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 233);
            Controls.Add(backBtn);
            Controls.Add(label8);
            Controls.Add(role_cb);
            Controls.Add(datePicker);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(lastname_txt);
            Controls.Add(firstname_txt);
            Controls.Add(address_txt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(password_txt);
            Controls.Add(username_txt);
            Controls.Add(nextBtn);
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUp";
            Load += SignUp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private RadioButton instructor_rbtn;
        private RadioButton supervisor_rbtn;
        private RadioButton student_rbtn;
        private Label label2;
        private Label label1;
        private TextBox password_txt;
        private TextBox username_txt;
        private Button nextBtn;
        private Label label4;
        private Label label5;
        private TextBox address_txt;
        private TextBox firstname_txt;
        private TextBox lastname_txt;
        private Label label6;
        private Label label7;
        private DateTimePicker datePicker;
        private Label label3;
        private ComboBox role_cb;
        private Label label8;
        private Button backBtn;
    }
}