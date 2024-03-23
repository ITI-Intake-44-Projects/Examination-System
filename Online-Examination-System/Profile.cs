using Code_First;
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
    public partial class Profile : Form
    {
        Student student;
        OnlineExaminatonSystemContext db;
        public Profile(Student _student, OnlineExaminatonSystemContext _db)
        {
            InitializeComponent();
            student = _student;
            db = _db;
            newImgBtn.BackColor = Color.FromArgb(52, 152, 219);
            resetPasswordBtn.BackColor = Color.FromArgb(92, 184, 92);
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            mobile.Text = $"Mobile: {student.Mobile}";
            gender.Text = $"Gender: {student.Gender}";
            track.Text = $"Track: {student.Track.Name}";
            username.Text = $"Username: {student.UserName}";
            name.Text = $"Name: {student.Fname} {student.Lname} ";
            faculty.Text = $"Faculty: {student.Faculty.Substring(0, Math.Min(student.Faculty.Length, 25))}";
            address.Text = $"Address: {student.Address.Substring(0, Math.Min(student.Address.Length, 25))}";
            date.Text = $"BirthDate: {student.BirthDate.Value.Year}-{student.BirthDate.Value.Month}-{student.BirthDate.Value.Day}";
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
            Change_Password change_Password = new Change_Password(student, db);
            this.Hide();
            change_Password.FormClosed += (obj, args) => this.Close(); ;
            change_Password.Show();
        }
    }
}
