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

namespace Online_Examination_System
{
    public partial class StudentNavigationArea : Form
    {

        private Form activeForm;

        Student student;
        OnlineExaminatonSystemContext db;
        public StudentNavigationArea(Student _student, OnlineExaminatonSystemContext _db)
        {
            InitializeComponent();
            student = _student;
            db = _db;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.AutoSize = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.HorizontalScroll.Enabled = false;

        }



        private void OpenChildForm(Form childForm) // , object btnSender
        {
            if (activeForm != null)
                activeForm.Close();

            //ActivateButton(btnSender);

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();

            childForm.Show();
            title.Text = childForm.Text;
        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Profile(student, db));
        }

        private void coursesBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new StudentCourses(student, db));
        }

        private void PreviousExamsBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PreviousExams(student, db));
        }

        private void requestExamBtn_Click(object sender, EventArgs e)
        {


        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Login signUp = new Login();
            this.Hide();
            signUp.FormClosed += (obj, args) => this.Close(); ;
            signUp.Show();
        }



        private void logoutBtn_Click_1(object sender, EventArgs e)
        {

        }

        private void StudentNavigationArea_Load(object sender, EventArgs e)
        {
            var courses = db.Courses.ToList();
            courses_box.DataSource = courses;
            courses_box.DisplayMember = "Name";
            courses_box.ValueMember = "Crs_ID";
        }

        private void requestExamBtn_Click_1(object sender, EventArgs e)
        {
            int crs_id = (int)courses_box.SelectedValue;
            var exam = db.StudentCourseExam.Where(ex => ex.Crs_Id == crs_id && ex.St_Id == student.St_Id).FirstOrDefault();
            if (exam != null)
            {
                MessageBox.Show("You have been already examined in this course", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                // Exam requestExam = new Exam(student, db, db.Courses.Where(c => c.Crs_ID == crs_id).FirstOrDefault());
                OpenChildForm(new Exam(student, db, db.Courses.Where(c => c.Crs_ID == crs_id).FirstOrDefault()));

                //requestExam.Show();
            }
        }

       

       
    }
}
