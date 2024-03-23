namespace Online_Examination_System
{
    partial class instructorProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(instructorProfile));
            name = new Label();
            username = new Label();
            address = new Label();
            date = new Label();
            picBox = new PictureBox();
            newImgBtn = new Button();
            resetPasswordBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)picBox).BeginInit();
            SuspendLayout();
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            name.ForeColor = Color.Black;
            name.Location = new Point(49, 220);
            name.Name = "name";
            name.Size = new Size(125, 37);
            name.TabIndex = 0;
            name.Text = "Fullname";
            // 
            // username
            // 
            username.AutoSize = true;
            username.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            username.ForeColor = Color.Black;
            username.Location = new Point(49, 281);
            username.Name = "username";
            username.Size = new Size(136, 37);
            username.TabIndex = 1;
            username.Text = "Username";
            // 
            // address
            // 
            address.AutoSize = true;
            address.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            address.ForeColor = Color.Black;
            address.Location = new Point(386, 281);
            address.Name = "address";
            address.Size = new Size(111, 37);
            address.TabIndex = 3;
            address.Text = "Address";
            // 
            // date
            // 
            date.AutoSize = true;
            date.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            date.ForeColor = Color.Black;
            date.Location = new Point(386, 220);
            date.Name = "date";
            date.Size = new Size(128, 37);
            date.TabIndex = 5;
            date.Text = "BirthDate";
            // 
            // picBox
            // 
            picBox.Image = (Image)resources.GetObject("picBox.Image");
            picBox.Location = new Point(224, 23);
            picBox.Name = "picBox";
            picBox.Size = new Size(143, 147);
            picBox.SizeMode = PictureBoxSizeMode.Zoom;
            picBox.TabIndex = 9;
            picBox.TabStop = false;
            // 
            // newImgBtn
            // 
            newImgBtn.Location = new Point(89, 379);
            newImgBtn.Name = "newImgBtn";
            newImgBtn.Size = new Size(154, 38);
            newImgBtn.TabIndex = 10;
            newImgBtn.Text = "Choose New Image";
            newImgBtn.UseVisualStyleBackColor = true;
            newImgBtn.Click += newImgBtn_Click;
            // 
            // resetPasswordBtn
            // 
            resetPasswordBtn.Location = new Point(340, 379);
            resetPasswordBtn.Name = "resetPasswordBtn";
            resetPasswordBtn.Size = new Size(145, 39);
            resetPasswordBtn.TabIndex = 11;
            resetPasswordBtn.Text = "Change Password";
            resetPasswordBtn.UseVisualStyleBackColor = true;
            resetPasswordBtn.Click += resetPasswordBtn_Click;
            // 
            // instructorProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(799, 519);
            Controls.Add(resetPasswordBtn);
            Controls.Add(newImgBtn);
            Controls.Add(picBox);
            Controls.Add(date);
            Controls.Add(address);
            Controls.Add(username);
            Controls.Add(name);
            Name = "instructorProfile";
            Text = "instructorProfile";
            Load += InstructorProfile_Load;
            ((System.ComponentModel.ISupportInitialize)picBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label name;
        private Label username;
        private Label address;
        private Label date;
        private PictureBox picBox;
        private Button newImgBtn;
        private Button resetPasswordBtn;
    }
}