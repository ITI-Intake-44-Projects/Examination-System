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
    public partial class CompleteSignUpAsStudent : Form
    {
        Student student;
        public CompleteSignUpAsStudent(Student student)
        {
            InitializeComponent();
            this.student = student;
        }

        OnlineExaminatonSystemContext db;
        private void CompleteSignUpAsStudent_Load(object sender, EventArgs e)
        {
            db = new OnlineExaminatonSystemContext();
            var tracks = db.Tracks.Select(t => new { t.Name, t.Trk_ID }).ToList();
            track_cb.DataSource = tracks;
            track_cb.DisplayMember = "Name";
            track_cb.ValueMember = "Trk_ID";
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                student.Faculty = faculty_txt.Text;
                student.Mobile = mobile_txt.Text;
                student.Gender = gender_cb.SelectedItem.ToString();
                student.TrackId = (int)track_cb.SelectedValue;
                try
                {
                    db.Add(student);
                    db.SaveChanges();
                    MessageBox.Show("Sign up completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    studentDashboard studentDashboard = new studentDashboard(student, db);
                    this.Hide();
                    studentDashboard.FormClosed += (obj, args) => this.Close();
                    studentDashboard.Show();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to save changes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fill all data.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateData()
        {
            if (string.IsNullOrWhiteSpace(faculty_txt.Text))
            {
                MessageBox.Show("Faculty cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(mobile_txt.Text))
            {
                MessageBox.Show("Mobile number cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(mobile_txt.Text, out _))
            {
                MessageBox.Show("Mobile number must be a valid integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
