using Online_Examination_System.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Examination_System
{
    public partial class PreviousExams : Form
    {
        OnlineExaminatonSystemContext context = new OnlineExaminatonSystemContext();
        Student st;
        
        public PreviousExams(Student _st, OnlineExaminatonSystemContext _context)
        {
            InitializeComponent();
            st = _st;
           context = _context;
        }

        private void PreviousExams_Load(object sender, EventArgs e)
        {
            var exams = context.StudentCourseExam.Where(s=> s.St_Id == st.St_Id).ToList();
            int y = 50;
            int x = 50;
            foreach (var exam in exams) 
            {
                Panel p = new Panel();
                p.Location = new System.Drawing.Point(x, y);
                p.AutoSize = true;
                //p.Size = new System.Drawing.Size(200, 500);
                Controls.Add(p);
                var CourseName = new Label();
                string passed = "";
                passed = exam.Passed == 1 ? "Passed" : "Failed";

                CourseName.AutoSize = true;
                CourseName.Text = $"Course: {exam.Course.Name}        Grade: {exam.Grade.ToString()}        Status:{passed}";
                CourseName.Font = new Font("Arial", 20);
                //CourseName.Location = new Point(10, 10);
                p.Controls.Add(CourseName);

                y += p.Height + 20;
            }

        }


    }
}
