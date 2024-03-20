using Online_Examination_System.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Online_Examination_System
{
    public partial class InsChoices : Form
    {
        Question question;
        OnlineExaminatonSystemContext db;
        public InsChoices(Question _question, OnlineExaminatonSystemContext _db)
        {
            InitializeComponent();
            db = _db;

            question = _question;
        }

        private void InsChoices_Load(object sender, EventArgs e)
        {
            txt_name.Text = question.Name;
            txt_marks.Text = question.Marks.ToString();
            txt_answer.Text = question.ModelAns;
            txt_type.Text = question.type;
            txt_qid.Text = question.Q_Id.ToString();
            txt_choice.Text = "";
            UpdateDataGridView();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txt_choice.Text = "";
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {

            QuestionChoice qc = new QuestionChoice();
            qc.Ques_id = question.Q_Id;
            qc.Choice = txt_choice.Text;
            db.Ques_Choices.Add(qc);
            // Save changes to the database
            db.SaveChanges();
            UpdateDataGridView();
        }


        private void UpdateDataGridView()
        {
            int questionId = question.Q_Id;
            var choices = db.Ques_Choices
                            .Where(choice => choice.Ques_id == questionId)
                            .Select(choice => new { choice.Ques_id, choice.Choice })
                            .ToList();

            dataGridView1.DataSource = choices;
        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            // Check if any row is selected
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected choice
                string choiceToDelete = dataGridView1.CurrentRow.Cells[1].Value.ToString();

                // Find the choice in the database
                QuestionChoice selectedChoice = db.Ques_Choices.FirstOrDefault(choice => choice.Ques_id == question.Q_Id && choice.Choice == choiceToDelete);

                if (selectedChoice != null)
                {
                    // Remove the selected choice from the database
                    db.Ques_Choices.Remove(selectedChoice);

                    // Save changes to the database
                    db.SaveChanges();

                    // Update the DataGridView
                    UpdateDataGridView(); // Assuming you have a method to update your DataGridView
                }
            }
            else
            {
                // If no row is selected, display a message to the user
                MessageBox.Show("Please select a choice to delete.", "No Choice Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Cells.Count > 0)
            {

                txt_choice.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }
        }
    
    }
}
