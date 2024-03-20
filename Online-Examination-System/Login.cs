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
using static System.Runtime.InteropServices.JavaScript.JSType;
 
namespace Online_Examination_System
{
    public partial class Login : Form
    {
        OnlineExaminatonSystemContext db;
        public Login()
        {
            InitializeComponent();
            db = new OnlineExaminatonSystemContext();
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            if (instructor_rbtn.Checked)
            {
                var instructor = db.Instructors.FirstOrDefault(i => i.Username == username_txt.Text);
                if (instructor == null)
                {
                    MessageBox.Show("Invalid username", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    username_txt.Text = password_txt.Text = "";
                }
                else
                {
                    if (instructor.Password == password_txt.Text)
                    {
                        MessageBox.Show($"Welcome back {instructor.Username} :)", "Login done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        username_txt.Text = password_txt.Text = "";
                        instructorDashboard instructorDashboard = new instructorDashboard(instructor, db);
                        this.Hide();
                        instructorDashboard.FormClosed += (obj, args) => this.Close(); ;
                        instructorDashboard.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        username_txt.Text = password_txt.Text = "";
                    }
                }
            }
            else if (supervisor_rbtn.Checked)
            {
                var supervisor = db.Tracks.FirstOrDefault(i => i.TrackSupervisor.Username == username_txt.Text);
                if (supervisor == null)
                {
                    MessageBox.Show("Invalid username", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    username_txt.Text = password_txt.Text = "";
                }
                else
                {
                    if (supervisor.TrackSupervisor.Password == password_txt.Text)
                    {
                        MessageBox.Show($"Welcome back {supervisor.TrackSupervisor.Username} :)", "Login done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        username_txt.Text = password_txt.Text = "";
                        ViewReports ViewReports = new ViewReports();
                        this.Hide();
                        ViewReports.FormClosed += (obj, args) => this.Close(); ;
                        ViewReports.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        username_txt.Text = password_txt.Text = "";
                    }
                }
            }
            else if (student_rbtn.Checked)
            {
                var student = db.Students.FirstOrDefault(i => i.UserName == username_txt.Text);
                if (student == null)
                {
                    MessageBox.Show("Invalid username", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    username_txt.Text = password_txt.Text = "";
                }
                else
                {
                    if (student.Passowrd == password_txt.Text)
                    {
                        MessageBox.Show($"Welcome back {student.UserName} :)", "Login done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        username_txt.Text = password_txt.Text = "";
                        studentDashboard studentDashboard = new studentDashboard(student, db);
                        this.Hide();
                        studentDashboard.FormClosed += (obj, args) => this.Close(); ;
                        studentDashboard.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        username_txt.Text = password_txt.Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill all data", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signUp = new SignUp();
            this.Hide();
            signUp.FormClosed += (obj, args) => this.Close(); ;
            signUp.Show();
        }

        private void student_rbtn_CheckedChanged(object sender, EventArgs e){} // ×××× 
    }
}
