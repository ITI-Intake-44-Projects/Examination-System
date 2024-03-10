using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Online_Examination_System.Models;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using System.Diagnostics;
namespace Online_Examination_System
{
    public partial class Exam : Form
    {
        OnlineExaminatonSystemContext sys = new OnlineExaminatonSystemContext();
        //OnlineExaminatonSystemContext sys;
        Student student;
        Course course;
        List<string> Answers = new List<string>();

        public Exam()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        public Exam(Student _st, OnlineExaminatonSystemContext _sys, Course course) : this()
        {
            student = _st;
            this.course = course;

            //sys = _sys;

        }
        
        private void submit_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control is Panel panel)
                {
                    foreach (Control innerControl in panel.Controls)
                    {
                        if (innerControl is RadioButton radioButton && radioButton.Checked)
                        {
                            Answers.Add(radioButton.Text);
                        }
                    }
                }
            }

            if (Answers.Count < 10)
            {
                MessageBox.Show("Please Answer All the Questions","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                using (var sys = new OnlineExaminatonSystemContext())
                {

                    string sqlQuery = $"EXEC examAnswers @crs_name ,@usr_name,@ans1,@ans2,@ans3,@ans4,@ans5,@ans6,@ans7,@ans8,@ans9,@ans10";

                    int rowsAffected = sys.Database.ExecuteSqlRaw(sqlQuery,
                        new SqlParameter("@crs_name", course.Name),
                        new SqlParameter("@usr_name", student.UserName),
                        new SqlParameter("@ans1", Answers[0]),
                        new SqlParameter("@ans2", Answers[1]),
                        new SqlParameter("@ans3", Answers[2]),
                        new SqlParameter("@ans4", Answers[3]),
                        new SqlParameter("@ans5", Answers[4]),
                        new SqlParameter("@ans6", Answers[5]),
                        new SqlParameter("@ans7", Answers[6]),
                        new SqlParameter("@ans8", Answers[7]),
                        new SqlParameter("@ans9", Answers[8]),
                        new SqlParameter("@ans10", Answers[9])
                       );

                    string sqlQuery2 = $"EXEC examCorrection @crs_name,@usr_name";

                    int rowsAffected2 = sys.Database.ExecuteSqlRaw(sqlQuery2,
                        new SqlParameter("@crs_name", course.Name),
                        new SqlParameter("@usr_name", student.UserName)
                    );
                }
                var pass = sys.StudentCourseExam.Where(sc => sc.Crs_Id == course.Crs_ID && sc.St_Id == student.St_Id).FirstOrDefault();
                DialogResult result;
                if (pass.Passed == 1)
                {
                    result = MessageBox.Show($"Congratulations you have passed the exam with grade {pass.Grade} ", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    result = MessageBox.Show($"Sorry you have failed on the exam with grade {pass.Grade} ", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                if (result == DialogResult.OK)
                {
                    this.Close();
                }
            }
           

        }

        private void Exam_Load(object sender, EventArgs e)
        {
            using (var sys = new OnlineExaminatonSystemContext())
            {

                string sqlQuery = $"EXEC examGeneration @Parameter1, @Parameter2, @Parameter3, @Parameter4";

                int rowsAffected = sys.Database.ExecuteSqlRaw(sqlQuery,
                    new SqlParameter("@Parameter1", course.Name),
                    new SqlParameter("@Parameter2", 7),
                    new SqlParameter("@Parameter3", 3),
                    new SqlParameter("@Parameter4", student.St_Id)
                   );
            }
            var exam_id = sys.StudentCourseExam.Where(e => e.Crs_Id == course.Crs_ID && e.St_Id == student.St_Id).Select(e => e.Exam_Id).FirstOrDefault();
            var questions = sys.Exam_Ques_St.Where(e => e.Ex_id == exam_id && e.St_id == student.St_Id).ToList();
            int y = 50;
            int count = 1;
            foreach (var q in questions)
            {
                Panel groupBox1 = new Panel();
                groupBox1.Location = new System.Drawing.Point(40, y);
                groupBox1.Size = q.Ques.type == "tf" ? new System.Drawing.Size(700, 100) : new System.Drawing.Size(700, 200);


                Controls.Add(groupBox1);

                Label l1 = new Label();
                l1.Text = $"Q{count++}-{q.Ques.Name}";
                l1.Size = new System.Drawing.Size(500, 20);
                groupBox1.Controls.Add(l1);

                int radioButtonY = 40;
                foreach (var c in q.Ques.Choices)
                {

                    var c1 = new RadioButton();
                    c1.Location = new System.Drawing.Point(50, radioButtonY);
                    c1.Size = new System.Drawing.Size(700, 20);
                    c1.Text = c.Choice;
                    groupBox1.Controls.Add(c1);
                    radioButtonY += 40;
                }
                y += groupBox1.Height + 20;
            }

            Panel ButtonBox = new Panel();
            ButtonBox.Location = new System.Drawing.Point((this.Width / 2), y);
            ButtonBox.Size = new System.Drawing.Size(180, 80);

            Controls.Add(ButtonBox);

            Button submit = new Button();
            submit.Size = new System.Drawing.Size(175, 45);
            submit.Text = "Sumbit";
            submit.Click += submit_Click;
            ButtonBox.Controls.Add(submit);
        }
    }
}
