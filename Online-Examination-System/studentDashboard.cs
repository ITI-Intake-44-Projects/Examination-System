using Online_Examination_System.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Examination_System
{
    public partial class studentDashboard : Form
    {
        Student student;
        OnlineExaminatonSystemContext db;
        public studentDashboard(Student _student, OnlineExaminatonSystemContext _db)
        {
            InitializeComponent();
            db = _db;
            student = _student;
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.FormClosed += (obj, args) => this.Close(); ;
            login.Show();
        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(student, db);
            //this.Hide();
            profile.Show();
        }

        private void coursesBtn_Click(object sender, EventArgs e)
        {
            StudentCourses studentCourses = new StudentCourses(student, db);
            //this.Hide();
            //studentCourses.FormClosed += (obj, args) => this.Close(); ;
            studentCourses.Show();
        }

        private void prevExamsBtn_Click(object sender, EventArgs e)
        {
            PreviousExams previousExams = new PreviousExams(student, db);
            //this.Hide();
            //previousExams.FormClosed += (obj, args) => this.Close(); ;
            previousExams.Show();
        }

        private void requestExamBtn_Click(object sender, EventArgs e)
        {
            int crs_id = (int)courses_box.SelectedValue;
            var exam = db.StudentCourseExam.Where(ex => ex.Crs_Id == crs_id && ex.St_Id == student.St_Id).FirstOrDefault();
            if (exam != null)
            {
                MessageBox.Show("You have been already examined in this course", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                Exam requestExam = new Exam(student, db,db.Courses.Where(c=>c.Crs_ID == crs_id).FirstOrDefault());
                requestExam.Show();
            }
            
            //this.Hide();
            //requestExam.FormClosed += (obj, args) => this.Close(); ;
        }

       

        private void studentDashboard_Load(object sender, EventArgs e)
        {
            var courses = db.Courses.ToList();
            courses_box.DataSource = courses;
            courses_box.DisplayMember = "Name";
            courses_box.ValueMember = "Crs_ID";
        }
    }
}
