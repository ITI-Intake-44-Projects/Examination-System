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
            pass = new Label();
            address = new Label();
            mobile = new Label();
            date = new Label();
            gender = new Label();
            faculty = new Label();
            track = new Label();
            SuspendLayout();
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            name.Location = new Point(87, 54);
            name.Name = "name";
            name.Size = new Size(125, 37);
            name.TabIndex = 0;
            name.Text = "Fullname";
            // 
            // username
            // 
            username.AutoSize = true;
            username.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            username.Location = new Point(87, 108);
            username.Name = "username";
            username.Size = new Size(132, 37);
            username.TabIndex = 1;
            username.Text = "username";
            // 
            // pass
            // 
            pass.AutoSize = true;
            pass.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pass.Location = new Point(87, 161);
            pass.Name = "pass";
            pass.Size = new Size(130, 37);
            pass.TabIndex = 2;
            pass.Text = "password";
            // 
            // address
            // 
            address.AutoSize = true;
            address.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            address.Location = new Point(87, 467);
            address.Name = "address";
            address.Size = new Size(111, 37);
            address.TabIndex = 3;
            address.Text = "Address";
            // 
            // mobile
            // 
            mobile.AutoSize = true;
            mobile.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mobile.Location = new Point(85, 417);
            mobile.Name = "mobile";
            mobile.Size = new Size(101, 37);
            mobile.TabIndex = 4;
            mobile.Text = "Mobile";
            // 
            // date
            // 
            date.AutoSize = true;
            date.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            date.Location = new Point(85, 266);
            date.Name = "date";
            date.Size = new Size(128, 37);
            date.TabIndex = 5;
            date.Text = "BirthDate";
            // 
            // gender
            // 
            gender.AutoSize = true;
            gender.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gender.Location = new Point(87, 215);
            gender.Name = "gender";
            gender.Size = new Size(104, 37);
            gender.TabIndex = 6;
            gender.Text = "Gender";
            // 
            // faculty
            // 
            faculty.AutoSize = true;
            faculty.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            faculty.Location = new Point(85, 364);
            faculty.Name = "faculty";
            faculty.Size = new Size(99, 37);
            faculty.TabIndex = 7;
            faculty.Text = "Faculty";
            // 
            // track
            // 
            track.AutoSize = true;
            track.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            track.Location = new Point(87, 318);
            track.Name = "track";
            track.Size = new Size(74, 37);
            track.TabIndex = 8;
            track.Text = "track";
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(653, 547);
            Controls.Add(track);
            Controls.Add(faculty);
            Controls.Add(gender);
            Controls.Add(date);
            Controls.Add(mobile);
            Controls.Add(address);
            Controls.Add(pass);
            Controls.Add(username);
            Controls.Add(name);
            Name = "Profile";
            Text = "Profile";
            Load += Profile_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label name;
        private Label username;
        private Label pass;
        private Label address;
        private Label mobile;
        private Label date;
        private Label gender;
        private Label faculty;
        private Label track;
    }
}