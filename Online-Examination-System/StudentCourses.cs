using Microsoft.EntityFrameworkCore;
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
    public partial class StudentCourses : Form
    {
        Student student;
        OnlineExaminatonSystemContext db;
        public StudentCourses(Student _student, OnlineExaminatonSystemContext _db)
        {
            InitializeComponent();
            student = _student;
            db = _db;
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.FormClosed += (obj, args) => this.Close(); ;
            login.Show();
        }

        private void StudentCourses_Load(object sender, EventArgs e)
        {
            var courses = db.Courses.Select(c => new { 
                c.Name, c.Duration, 
                Instructors = string.Join(", ", c.Instructor_Courses.Select(ic => $"{ic.Instructor.FName} {ic.Instructor.LName}"))
            }).ToList();

            coursesDgv.DataSource = courses;
        }
    }
}
