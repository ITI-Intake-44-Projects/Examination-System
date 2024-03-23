namespace Online_Examination_System
{
    partial class insProfile
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
            lbl_insID = new Label();
            label2 = new Label();
            txt_fname = new TextBox();
            txt_lname = new TextBox();
            label3 = new Label();
            txt_addr = new TextBox();
            label4 = new Label();
            txt_whours = new TextBox();
            label5 = new Label();
            txt_birth = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(261, 87);
            label1.Name = "label1";
            label1.Size = new Size(58, 29);
            label1.TabIndex = 0;
            label1.Text = "ID : ";
            // 
            // lbl_insID
            // 
            lbl_insID.AutoSize = true;
            lbl_insID.Font = new Font("Arial", 14F, FontStyle.Bold);
            lbl_insID.ForeColor = Color.Black;
            lbl_insID.Location = new Point(552, 92);
            lbl_insID.Name = "lbl_insID";
            lbl_insID.Size = new Size(57, 22);
            lbl_insID.TabIndex = 1;
            lbl_insID.Text = "insID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 18F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(261, 126);
            label2.Name = "label2";
            label2.Size = new Size(157, 29);
            label2.TabIndex = 2;
            label2.Text = "First Name : ";
            // 
            // txt_fname
            // 
            txt_fname.BackColor = Color.Lavender;
            txt_fname.BorderStyle = BorderStyle.None;
            txt_fname.Font = new Font("Arial", 14F, FontStyle.Bold);
            txt_fname.ForeColor = Color.Black;
            txt_fname.Location = new Point(479, 133);
            txt_fname.Name = "txt_fname";
            txt_fname.ReadOnly = true;
            txt_fname.Size = new Size(156, 22);
            txt_fname.TabIndex = 3;
            txt_fname.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_lname
            // 
            txt_lname.BackColor = Color.Lavender;
            txt_lname.BorderStyle = BorderStyle.None;
            txt_lname.Font = new Font("Arial", 14F, FontStyle.Bold);
            txt_lname.ForeColor = Color.Black;
            txt_lname.Location = new Point(479, 170);
            txt_lname.Name = "txt_lname";
            txt_lname.ReadOnly = true;
            txt_lname.Size = new Size(156, 22);
            txt_lname.TabIndex = 5;
            txt_lname.TextAlign = HorizontalAlignment.Center;
            txt_lname.TextChanged += txt_lname_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 18F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(261, 165);
            label3.Name = "label3";
            label3.Size = new Size(147, 29);
            label3.TabIndex = 4;
            label3.Text = "Last Name :";
            // 
            // txt_addr
            // 
            txt_addr.BackColor = Color.Lavender;
            txt_addr.BorderStyle = BorderStyle.None;
            txt_addr.Font = new Font("Arial", 14F, FontStyle.Bold);
            txt_addr.ForeColor = Color.Black;
            txt_addr.Location = new Point(479, 208);
            txt_addr.Name = "txt_addr";
            txt_addr.ReadOnly = true;
            txt_addr.Size = new Size(156, 22);
            txt_addr.TabIndex = 7;
            txt_addr.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 18F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(261, 201);
            label4.Name = "label4";
            label4.Size = new Size(122, 29);
            label4.TabIndex = 6;
            label4.Text = "Address :";
            // 
            // txt_whours
            // 
            txt_whours.BackColor = Color.Lavender;
            txt_whours.BorderStyle = BorderStyle.None;
            txt_whours.Font = new Font("Arial", 14F, FontStyle.Bold);
            txt_whours.ForeColor = Color.Black;
            txt_whours.Location = new Point(479, 247);
            txt_whours.Name = "txt_whours";
            txt_whours.ReadOnly = true;
            txt_whours.Size = new Size(156, 22);
            txt_whours.TabIndex = 9;
            txt_whours.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 18F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(261, 240);
            label5.Name = "label5";
            label5.Size = new Size(200, 29);
            label5.TabIndex = 8;
            label5.Text = "Working Hours :";
            // 
            // txt_birth
            // 
            txt_birth.BackColor = Color.Lavender;
            txt_birth.BorderStyle = BorderStyle.None;
            txt_birth.Font = new Font("Arial", 14F, FontStyle.Bold);
            txt_birth.ForeColor = Color.Black;
            txt_birth.Location = new Point(479, 291);
            txt_birth.Name = "txt_birth";
            txt_birth.ReadOnly = true;
            txt_birth.Size = new Size(156, 22);
            txt_birth.TabIndex = 11;
            txt_birth.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 18F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(261, 286);
            label6.Name = "label6";
            label6.Size = new Size(134, 29);
            label6.TabIndex = 10;
            label6.Text = "BirthDate :";
            // 
            // insProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(876, 521);
            Controls.Add(txt_birth);
            Controls.Add(label6);
            Controls.Add(txt_whours);
            Controls.Add(label5);
            Controls.Add(txt_addr);
            Controls.Add(label4);
            Controls.Add(txt_lname);
            Controls.Add(label3);
            Controls.Add(txt_fname);
            Controls.Add(label2);
            Controls.Add(lbl_insID);
            Controls.Add(label1);
            Name = "insProfile";
            Text = "Instractor Profile";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbl_insID;
        private Label label2;
        private TextBox txt_fname;
        private TextBox txt_lname;
        private Label label3;
        private TextBox txt_addr;
        private Label label4;
        private TextBox txt_whours;
        private Label label5;
        private TextBox txt_birth;
        private Label label6;
    }
}