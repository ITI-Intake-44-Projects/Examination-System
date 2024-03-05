namespace Online_Examination_System
{
    partial class CompleteSignUpAsStudent
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            faculty_txt = new TextBox();
            mobile_txt = new TextBox();
            track_cb = new ComboBox();
            signup_btn = new Button();
            label5 = new Label();
            gender_cb = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 77);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Faculty";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 113);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 2;
            label2.Text = "Mobile";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 150);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 4;
            label3.Text = "Gender";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 190);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 6;
            label4.Text = "Track";
            // 
            // faculty_txt
            // 
            faculty_txt.Location = new Point(122, 74);
            faculty_txt.Name = "faculty_txt";
            faculty_txt.PlaceholderText = "Faculty";
            faculty_txt.Size = new Size(122, 23);
            faculty_txt.TabIndex = 1;
            // 
            // mobile_txt
            // 
            mobile_txt.Location = new Point(122, 110);
            mobile_txt.Name = "mobile_txt";
            mobile_txt.PlaceholderText = "Mobile";
            mobile_txt.Size = new Size(122, 23);
            mobile_txt.TabIndex = 3;
            // 
            // track_cb
            // 
            track_cb.FormattingEnabled = true;
            track_cb.Location = new Point(123, 187);
            track_cb.Name = "track_cb";
            track_cb.Size = new Size(121, 23);
            track_cb.TabIndex = 7;
            // 
            // signup_btn
            // 
            signup_btn.Location = new Point(103, 231);
            signup_btn.Name = "signup_btn";
            signup_btn.Size = new Size(75, 23);
            signup_btn.TabIndex = 8;
            signup_btn.Text = "Sign Up";
            signup_btn.UseVisualStyleBackColor = true;
            signup_btn.Click += signup_btn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F);
            label5.Location = new Point(37, 18);
            label5.Name = "label5";
            label5.Size = new Size(234, 37);
            label5.TabIndex = 9;
            label5.Text = "Complete Sign Up";
            // 
            // gender_cb
            // 
            gender_cb.FormattingEnabled = true;
            gender_cb.Items.AddRange(new object[] { "Male", "Female" });
            gender_cb.Location = new Point(122, 147);
            gender_cb.Name = "gender_cb";
            gender_cb.Size = new Size(121, 23);
            gender_cb.TabIndex = 5;
            // 
            // CompleteSignUpAsStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(295, 289);
            Controls.Add(label1);
            Controls.Add(gender_cb);
            Controls.Add(label5);
            Controls.Add(signup_btn);
            Controls.Add(track_cb);
            Controls.Add(mobile_txt);
            Controls.Add(faculty_txt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "CompleteSignUpAsStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CompleteSignUp";
            Load += CompleteSignUpAsStudent_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox faculty_txt;
        private TextBox mobile_txt;
        private ComboBox track_cb;
        private Button signup_btn;
        private Label label5;
        private ComboBox gender_cb;
    }
}