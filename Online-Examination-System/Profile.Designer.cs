namespace Online_Examination_System
{
    partial class Profile
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
            name = new Label();
            username = new Label();
            address = new Label();
            mobile = new Label();
            date = new Label();
            gender = new Label();
            faculty = new Label();
            track = new Label();
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
            name.Location = new Point(57, 229);
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
            username.Location = new Point(57, 290);
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
            address.Location = new Point(57, 421);
            address.Name = "address";
            address.Size = new Size(111, 37);
            address.TabIndex = 3;
            address.Text = "Address";
            // 
            // mobile
            // 
            mobile.AutoSize = true;
            mobile.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mobile.ForeColor = Color.Black;
            mobile.Location = new Point(532, 421);
            mobile.Name = "mobile";
            mobile.Size = new Size(101, 37);
            mobile.TabIndex = 4;
            mobile.Text = "Mobile";
            // 
            // date
            // 
            date.AutoSize = true;
            date.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            date.ForeColor = Color.Black;
            date.Location = new Point(532, 229);
            date.Name = "date";
            date.Size = new Size(128, 37);
            date.TabIndex = 5;
            date.Text = "BirthDate";
            // 
            // gender
            // 
            gender.AutoSize = true;
            gender.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gender.ForeColor = Color.Black;
            gender.Location = new Point(532, 353);
            gender.Name = "gender";
            gender.Size = new Size(104, 37);
            gender.TabIndex = 6;
            gender.Text = "Gender";
            // 
            // faculty
            // 
            faculty.AutoSize = true;
            faculty.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            faculty.ForeColor = Color.Black;
            faculty.Location = new Point(57, 353);
            faculty.Name = "faculty";
            faculty.Size = new Size(99, 37);
            faculty.TabIndex = 7;
            faculty.Text = "Faculty";
            // 
            // track
            // 
            track.AutoSize = true;
            track.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            track.ForeColor = Color.Black;
            track.Location = new Point(532, 290);
            track.Name = "track";
            track.Size = new Size(77, 37);
            track.TabIndex = 8;
            track.Text = "Track";
            // 
            // picBox
            // 
            picBox.Image = Properties.Resources.me1;
            picBox.Location = new Point(333, 12);
            picBox.Name = "picBox";
            picBox.Size = new Size(143, 147);
            picBox.SizeMode = PictureBoxSizeMode.Zoom;
            picBox.TabIndex = 9;
            picBox.TabStop = false;
            // 
            // newImgBtn
            // 
            newImgBtn.Location = new Point(186, 485);
            newImgBtn.Name = "newImgBtn";
            newImgBtn.Size = new Size(154, 38);
            newImgBtn.TabIndex = 10;
            newImgBtn.Text = "Choose New Image";
            newImgBtn.UseVisualStyleBackColor = true;
            newImgBtn.Click += newImgBtn_Click;
            // 
            // resetPasswordBtn
            // 
            resetPasswordBtn.Location = new Point(446, 485);
            resetPasswordBtn.Name = "resetPasswordBtn";
            resetPasswordBtn.Size = new Size(145, 39);
            resetPasswordBtn.TabIndex = 11;
            resetPasswordBtn.Text = "Change Password";
            resetPasswordBtn.UseVisualStyleBackColor = true;
            resetPasswordBtn.Click += resetPasswordBtn_Click;
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(853, 604);
            Controls.Add(resetPasswordBtn);
            Controls.Add(newImgBtn);
            Controls.Add(picBox);
            Controls.Add(track);
            Controls.Add(faculty);
            Controls.Add(gender);
            Controls.Add(date);
            Controls.Add(mobile);
            Controls.Add(address);
            Controls.Add(username);
            Controls.Add(name);
            Name = "Profile";
            Text = "Profile";
            Load += Profile_Load;
            ((System.ComponentModel.ISupportInitialize)picBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label name;
        private Label username;
        private Label address;
        private Label mobile;
        private Label date;
        private Label gender;
        private Label faculty;
        private Label track;
        private PictureBox picBox;
        private Button newImgBtn;
        private Button resetPasswordBtn;
    }
}