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
            this.Hide();
            profile.FormClosed += (obj, args) => this.Close(); ;
            profile.Show();
        }
        
        private void coursesBtn_Click(object sender, EventArgs e)
        {
            StudentCourses studentCourses = new StudentCourses(student, db);
            this.Hide();
            studentCourses.FormClosed += (obj, args) => this.Close(); ;
            studentCourses.Show();
        }

        private void prevExamsBtn_Click(object sender, EventArgs e)
        {
            //PreviousExams previousExams = new PreviousExams(student, db);
            //this.Hide();
            //previousExams.FormClosed += (obj, args) => this.Close(); ;
            //previousExams.Show();
        }

        private void requestExamBtn_Click(object sender, EventArgs e)
        {
            RequestExam requestExam = new RequestExam(student, db);
            this.Hide();
            requestExam.FormClosed += (obj, args) => this.Close(); ;
            requestExam.Show();
        }
    }
}
