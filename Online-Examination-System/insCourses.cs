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
    public partial class insCourses : Form
    {
        Instructor instractor;
        OnlineExaminatonSystemContext db;
        public insCourses(Instructor _instractor, OnlineExaminatonSystemContext _db)
        {
            InitializeComponent();
            // to share the instractor data when show the form
            instractor = _instractor;
            //to share the database connection
            db = _db;

            //show all cources
      
            // Assuming you have an instance of your ITIContext class named 'db'
            int instructorId = instractor.Ins_ID; // Replace with the actual ID of the instructor you want to query

            var courseIds = db.Instructor_Course
                .Where(ic => ic.InstructorId == instructorId)
                .Select(ic => ic.CourseId)
                .ToList();

  
            // Select courses based on the obtained course IDs
      
            var relatedCourses = db.Courses
    .Where(course => courseIds.Contains(course.Crs_ID))
    .Select(course => new
    {
        course.Crs_ID,
        course.Name,
        course.Duration,
        course.Grade
    })
    .ToList();

            // Display the courses in dataGridView1
            dataGridView1.DataSource = relatedCourses;

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            instructorDashboard instructorDashboard = new instructorDashboard(instractor, db);
            this.Hide();
            instructorDashboard.FormClosed += (obj, args) => this.Close(); ;
            instructorDashboard.Show();
        }
    }
}
