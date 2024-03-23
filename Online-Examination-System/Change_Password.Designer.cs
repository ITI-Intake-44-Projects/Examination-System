namespace Code_First
{
    partial class Change_Password
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
            old_pass_txt = new TextBox();
            label2 = new Label();
            new_pass_txt = new TextBox();
            label3 = new Label();
            confirm_pass_txt = new TextBox();
            reset_password_btn = new Button();
            cancel_btn = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 87);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 0;
            label1.Text = "Old Password";
            // 
            // old_pass_txt
            // 
            old_pass_txt.Location = new Point(176, 84);
            old_pass_txt.Name = "old_pass_txt";
            old_pass_txt.PasswordChar = '*';
            old_pass_txt.PlaceholderText = "Enter your old password";
            old_pass_txt.Size = new Size(150, 23);
            old_pass_txt.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 136);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 2;
            label2.Text = "New Password";
            // 
            // new_pass_txt
            // 
            new_pass_txt.Location = new Point(176, 133);
            new_pass_txt.Name = "new_pass_txt";
            new_pass_txt.PasswordChar = '*';
            new_pass_txt.PlaceholderText = "Enter your new password";
            new_pass_txt.Size = new Size(150, 23);
            new_pass_txt.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 185);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.TabIndex = 4;
            label3.Text = "Confirm Password";
            // 
            // confirm_pass_txt
            // 
            confirm_pass_txt.Location = new Point(176, 182);
            confirm_pass_txt.Name = "confirm_pass_txt";
            confirm_pass_txt.PasswordChar = '*';
            confirm_pass_txt.PlaceholderText = "Confirm your Password";
            confirm_pass_txt.Size = new Size(150, 23);
            confirm_pass_txt.TabIndex = 5;
            // 
            // reset_password_btn
            // 
            reset_password_btn.Location = new Point(67, 225);
            reset_password_btn.Name = "reset_password_btn";
            reset_password_btn.Size = new Size(109, 29);
            reset_password_btn.TabIndex = 6;
            reset_password_btn.Text = "Change Password";
            reset_password_btn.UseVisualStyleBackColor = true;
            reset_password_btn.Click += reset_password_btn_Click;
            // 
            // cancel_btn
            // 
            cancel_btn.Location = new Point(209, 225);
            cancel_btn.Name = "cancel_btn";
            cancel_btn.Size = new Size(98, 29);
            cancel_btn.TabIndex = 7;
            cancel_btn.Text = "Cancel";
            cancel_btn.UseVisualStyleBackColor = true;
            cancel_btn.Click += cancel_btn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 15F);
            label4.Location = new Point(92, 28);
            label4.Name = "label4";
            label4.Size = new Size(179, 25);
            label4.TabIndex = 8;
            label4.Text = "Reseting Password";
            // 
            // Change_Password
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(367, 311);
            Controls.Add(label4);
            Controls.Add(cancel_btn);
            Controls.Add(reset_password_btn);
            Controls.Add(confirm_pass_txt);
            Controls.Add(label3);
            Controls.Add(new_pass_txt);
            Controls.Add(label2);
            Controls.Add(old_pass_txt);
            Controls.Add(label1);
            Name = "Change_Password";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Change_Password";
            Load += Change_Password_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox old_pass_txt;
        private Label label2;
        private TextBox new_pass_txt;
        private Label label3;
        private TextBox confirm_pass_txt;
        private Button reset_password_btn;
        private Button cancel_btn;
        private Label label4;
    }
}