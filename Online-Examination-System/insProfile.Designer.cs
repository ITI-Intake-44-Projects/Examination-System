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
            btn_back = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(12, 56);
            label1.Name = "label1";
            label1.Size = new Size(36, 21);
            label1.TabIndex = 0;
            label1.Text = "ID : ";
            // 
            // lbl_insID
            // 
            lbl_insID.AutoSize = true;
            lbl_insID.Font = new Font("Segoe UI", 12F);
            lbl_insID.Location = new Point(62, 56);
            lbl_insID.Name = "lbl_insID";
            lbl_insID.Size = new Size(45, 21);
            lbl_insID.TabIndex = 1;
            lbl_insID.Text = "insID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(12, 95);
            label2.Name = "label2";
            label2.Size = new Size(97, 21);
            label2.TabIndex = 2;
            label2.Text = "First Name : ";
            // 
            // txt_fname
            // 
            txt_fname.ForeColor = Color.FromArgb(255, 128, 128);
            txt_fname.Location = new Point(146, 96);
            txt_fname.Name = "txt_fname";
            txt_fname.ReadOnly = true;
            txt_fname.Size = new Size(156, 23);
            txt_fname.TabIndex = 3;
            // 
            // txt_lname
            // 
            txt_lname.ForeColor = Color.FromArgb(255, 192, 128);
            txt_lname.Location = new Point(146, 126);
            txt_lname.Name = "txt_lname";
            txt_lname.ReadOnly = true;
            txt_lname.Size = new Size(156, 23);
            txt_lname.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(12, 125);
            label3.Name = "label3";
            label3.Size = new Size(91, 21);
            label3.TabIndex = 4;
            label3.Text = "Last Name :";
            // 
            // txt_addr
            // 
            txt_addr.ForeColor = Color.FromArgb(255, 255, 128);
            txt_addr.Location = new Point(146, 160);
            txt_addr.Name = "txt_addr";
            txt_addr.ReadOnly = true;
            txt_addr.Size = new Size(156, 23);
            txt_addr.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(12, 159);
            label4.Name = "label4";
            label4.Size = new Size(73, 21);
            label4.TabIndex = 6;
            label4.Text = "Address :";
            // 
            // txt_whours
            // 
            txt_whours.ForeColor = Color.FromArgb(128, 255, 255);
            txt_whours.Location = new Point(146, 193);
            txt_whours.Name = "txt_whours";
            txt_whours.ReadOnly = true;
            txt_whours.Size = new Size(156, 23);
            txt_whours.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(12, 191);
            label5.Name = "label5";
            label5.Size = new Size(122, 21);
            label5.TabIndex = 8;
            label5.Text = "Working Hours :";
            // 
            // txt_birth
            // 
            txt_birth.ForeColor = Color.FromArgb(255, 128, 255);
            txt_birth.Location = new Point(146, 230);
            txt_birth.Name = "txt_birth";
            txt_birth.ReadOnly = true;
            txt_birth.Size = new Size(156, 23);
            txt_birth.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(12, 228);
            label6.Name = "label6";
            label6.Size = new Size(82, 21);
            label6.TabIndex = 10;
            label6.Text = "BirthDate :";
            // 
            // btn_back
            // 
            btn_back.Location = new Point(347, 263);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(92, 23);
            btn_back.TabIndex = 12;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // insProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 298);
            Controls.Add(btn_back);
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
        private Button btn_back;
    }
}