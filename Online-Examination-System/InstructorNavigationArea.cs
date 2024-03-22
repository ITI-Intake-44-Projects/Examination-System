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
    public partial class InstructorNavigationArea : Form
    {
        private Form activeForm;
        Instructor instructor;
        OnlineExaminatonSystemContext db;
        public InstructorNavigationArea(Instructor ins , OnlineExaminatonSystemContext _db)
        {
            InitializeComponent();
            instructor = ins;
            db= _db;
        }



        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();


            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            this.panel3.Controls.Add(childForm);
            //this.panelDesktopPanel.Controls.Add(childForm);
            //this.panelDesktopPanel.Tag = childForm;
             this.panel3.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
            title.Text = childForm.Text;
        }

        private void ProfileBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new insProfile(instructor, db));
        }

        private void coursesBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new insCourses(instructor, db));

        }

        private void Ques_Btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new insQuestions(instructor, db));
        }
        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Login signUp = new Login();
            this.Hide();
            signUp.FormClosed += (obj, args) => this.Close(); ;
            signUp.Show();
        }
    }
}
