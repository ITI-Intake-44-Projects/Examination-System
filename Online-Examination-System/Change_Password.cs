using Online_Examination_System;
using Online_Examination_System.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_First
{
    public partial class Change_Password : Form
    {
        Student student;
        Instructor instructor;
        OnlineExaminatonSystemContext db;
        public Change_Password(object person, OnlineExaminatonSystemContext db)
        {
            InitializeComponent();
            this.db = db;
            if(person as Student != null)
            {
                student = person as Student;
            } 
            else
            {
                instructor = person as Instructor;
            }
            reset_password_btn.BackColor = Color.Green;
            cancel_btn.BackColor = Color.Red;
        }

        private void Change_Password_Load(object sender, EventArgs e)
        {
        }

        private void reset_password_btn_Click(object sender, EventArgs e)
        {
            if (student != null)
            {
                if (student.Passowrd == old_pass_txt.Text)
                {
                    if (new_pass_txt.Text == "")
                    {
                        MessageBox.Show("Enter the new password", "Reset Password Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (new_pass_txt.Text.Length < 5)
                    {
                        MessageBox.Show("New password's Length must be at least 5 letters", "Reset Password Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (confirm_pass_txt.Text == new_pass_txt.Text)
                    {
                        student.Passowrd = new_pass_txt.Text;
                        db.SaveChanges();
                        MessageBox.Show("Password updated Successfully", "Reset Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        old_pass_txt.Text = new_pass_txt.Text = confirm_pass_txt.Text = "";

                        StudentNavigationArea studentNavigationArea = new StudentNavigationArea(student, db);
                        this.Hide();
                        studentNavigationArea.FormClosed += (obj, args) => this.Close(); ;
                        studentNavigationArea.Show();
                    }
                    else
                    {
                        MessageBox.Show("New Password and Confirm Password not matched", "Reset Password Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        old_pass_txt.Text = new_pass_txt.Text = confirm_pass_txt.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Old Password is incorrect", "Incorrect Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    old_pass_txt.Text = new_pass_txt.Text = confirm_pass_txt.Text = "";
                }
            } 
            
            else
            {
                if (instructor.Password == old_pass_txt.Text)
                {
                    if (new_pass_txt.Text == "")
                    {
                        MessageBox.Show("Enter the new password", "Reset Password Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (new_pass_txt.Text.Length < 5)
                    {
                        MessageBox.Show("New password's Length must be at least 5 letters", "Reset Password Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (confirm_pass_txt.Text == new_pass_txt.Text)
                    {
                        instructor.Password = new_pass_txt.Text;
                        db.SaveChanges();
                        MessageBox.Show("Password updated Successfully", "Reset Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        old_pass_txt.Text = new_pass_txt.Text = confirm_pass_txt.Text = "";

                        InstructorNavigationArea instructorNavigationArea = new InstructorNavigationArea(instructor, db);
                        this.Hide();
                        instructorNavigationArea.FormClosed += (obj, args) => this.Close(); ;
                        instructorNavigationArea.Show();
                    }
                    else
                    {
                        MessageBox.Show("New Password and Confirm Password not matched", "Reset Password Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        old_pass_txt.Text = new_pass_txt.Text = confirm_pass_txt.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Old Password is incorrect", "Incorrect Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    old_pass_txt.Text = new_pass_txt.Text = confirm_pass_txt.Text = "";
                }
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            if (student != null)
            {
                StudentNavigationArea studentNavigationArea = new StudentNavigationArea(student, db);
                this.Hide();
                studentNavigationArea.FormClosed += (obj, args) => this.Close(); ;
                studentNavigationArea.Show();
            }
            else
            {
                InstructorNavigationArea instructorNavigationArea = new InstructorNavigationArea(instructor, db);
                this.Hide();
                instructorNavigationArea.FormClosed += (obj, args) => this.Close(); ;
                instructorNavigationArea.Show();
            }

        }
    }
}
