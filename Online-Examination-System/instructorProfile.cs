using Code_First;
using Online_Examination_System.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Online_Examination_System
{
    public partial class instructorProfile : Form
    {
        private readonly Instructor instructor;
        private readonly OnlineExaminatonSystemContext db;

        public instructorProfile(Instructor _instructor, OnlineExaminatonSystemContext _db)
        {
            InitializeComponent();
            instructor = _instructor;
            db = _db;
            newImgBtn.BackColor = Color.FromArgb(52, 152, 219);
            resetPasswordBtn.BackColor = Color.FromArgb(92, 184, 92);
        }

        private void InstructorProfile_Load(object sender, EventArgs e)
        {
            name.Text = "Name: ";
            if (instructor.FName != null)
                name.Text += $"{instructor.FName} ";

            if (instructor.LName != null)
                name.Text += instructor.LName;

            if (instructor.Username != null)
                username.Text = $"Username: {instructor.Username}";
            else
                username.Text = $"Username: Undefined";

            if(instructor.Address != null)
                address.Text = $"Address: {instructor.Address.Substring(0, Math.Min(instructor.Address.Length, 25))}";
            else
                address.Text = $"Address: Undefined";

            if(instructor.Birthdate!=null)
                date.Text = $"BirthDate: {instructor.Birthdate.Value.Year}-{instructor.Birthdate.Value.Month}-{instructor.Birthdate.Value.Day}";
            else
                date.Text = $"BirthDate: Undefined";
        }

        private void newImgBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select new Image";
            openFileDialog.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.gif;*.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedImage = openFileDialog.FileName;
                picBox.Image = Image.FromFile(selectedImage);
            }
        }

        private void resetPasswordBtn_Click(object sender, EventArgs e)
        {
            Change_Password change_Password = new Change_Password(instructor, db);
            this.Hide();
            change_Password.FormClosed += (obj, args) => this.Close();
            change_Password.Show();
        }
    }
}