using Castle.Components.DictionaryAdapter.Xml;
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
    public partial class insQuestions : Form
    {
        Instructor instructor;
        OnlineExaminatonSystemContext db;
        public insQuestions(Instructor _instructor, OnlineExaminatonSystemContext _db)
        {
            InitializeComponent();
            db = _db;
            instructor = _instructor;
            loadDropDownListData();
        }
        public void loadDropDownListData()
        {
            int instructorId = instructor.Ins_ID;
            var QuestionType = new List<string> { "mcq", "tf" };
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

            // Populate the ComboBox with course names
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Crs_ID";
            comboBox1.DataSource = relatedCourses;

            ques_type.DataSource = QuestionType;

        }
        private void btn_back_Click(object sender, EventArgs e)
        {
            instructorDashboard instructorDashboard = new instructorDashboard(instructor, db);
            this.Hide();
            instructorDashboard.FormClosed += (obj, args) => this.Close(); ;
            instructorDashboard.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                var selectedCourse = (dynamic)comboBox1.SelectedItem;
                int courseId = selectedCourse.Crs_ID;
                loadQuestionsById(courseId);
                //MessageBox.Show($"Selected Course ID: {courseId}");
            }
        }

        public void loadQuestionsById(int crsid)
        {
            var questions = db.Questions
           .Where(q => q.Crs_Id == crsid)
           .Select(q => new
           {
               q.Q_Id,
               q.Name,
               q.type,
               q.Marks,
               q.ModelAns
           })
           .ToList();

            // Display the questions in DataGridView1
            dataGridView1.DataSource = questions;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                txt_name.Text = row.Cells[1].Value.ToString();
                //txt_type.Text = row.Cells[2].Value.ToString();
                ques_type.Text = row.Cells[2].Value.ToString();
                //txt_marks.Text = row.Cells[3].Value.ToString();
                txt_answer.Text = row.Cells[4].Value.ToString();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txt_name.Text = "";
            //txt_type.Text = "";
            //txt_marks.Text = "";
            txt_answer.Text = "";
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            Question q = new Question();
            q.Marks = 10;
            q.Name = txt_name.Text;
            //q.type = txt_type.Text;
            q.type = ques_type.SelectedValue.ToString();
            q.ModelAns = txt_answer.Text;

            var selectedCourse = (dynamic)comboBox1.SelectedItem;
            int courseId = selectedCourse.Crs_ID;
            q.Crs_Id = courseId;


            db.Questions.Add(q);
            db.SaveChanges();



            loadQuestionsById(courseId);

            txt_name.Text = "";
            //txt_type.Text = "";
            ques_type.Text = "";
            txt_answer.Text = "";
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the first value of the first cell in the selected row
                int qID = (int)dataGridView1.SelectedRows[0].Cells[0].Value;

                // Delete the record from the database based on the extracted qID
                var questionToDelete = db.Questions.FirstOrDefault(q => q.Q_Id == qID);

                if (questionToDelete != null)
                {
                    db.Questions.Remove(questionToDelete);
                    db.SaveChanges();

                    var selectedCourse = (dynamic)comboBox1.SelectedItem;
                    int courseId = selectedCourse.Crs_ID;


                    loadQuestionsById(courseId);
                    txt_name.Text = "";
                    //txt_type.Text = "";
                    ques_type.Text = "";
                    txt_answer.Text = "";
                }
                else
                {
                    MessageBox.Show("Question not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the first value of the first cell in the selected row
                int qID = (int)dataGridView1.SelectedRows[0].Cells[0].Value;

                // Retrieve the question to update from the database based on the extracted qID
                var questionToUpdate = db.Questions.FirstOrDefault(q => q.Q_Id == qID);

                if (questionToUpdate != null)
                {
                    // Update the question properties with values from your textboxes or other input controls
                    questionToUpdate.Name = txt_name.Text;
                    //questionToUpdate.type = txt_type.Text;
                    questionToUpdate.type = ques_type.Text;
                    questionToUpdate.Marks = 10;
                    questionToUpdate.ModelAns = txt_answer.Text;

                    db.SaveChanges();

                    var selectedCourse = (dynamic)comboBox1.SelectedItem;
                    int courseId = selectedCourse.Crs_ID;

                    // Reload the DataGridView to reflect the changes
                    loadQuestionsById(courseId);

                    // Clear the textboxes after updating
                    txt_name.Text = "";
                    //txt_type.Text = "";
                    ques_type.Text = "";
                    txt_answer.Text = "";
                }
                else
                {
                    MessageBox.Show("Question not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }
        private void btnInsChoices_Click(object sender, EventArgs e)
        {
            // Check if any row is selected in the DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
             
                // Get the first value of the first cell in the selected row
                int qID = (int)dataGridView1.SelectedRows[0].Cells[0].Value;

                // Retrieve the question to update from the database based on the extracted qID
                Question question = db.Questions.FirstOrDefault(q => q.Q_Id == qID);

                InsChoices formchoices = new InsChoices(question, db);
                formchoices.Show();
            }
            else
            {
                // If no row is selected, display a message to the user
                MessageBox.Show("Please select a row before proceeding.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }


}
