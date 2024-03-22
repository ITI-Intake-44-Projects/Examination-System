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
    public partial class SuperVisorNavigationArea : Form
    {

        private Form activeForm;
        Instructor instructor;
        OnlineExaminatonSystemContext db;


        public SuperVisorNavigationArea(Instructor _instructor, OnlineExaminatonSystemContext _db)
        {
            InitializeComponent();
            instructor = _instructor;
            db = _db;
            // this.AutoSize = false;
            //this.HorizontalScroll.Enabled = false;
        }
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();


            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            //childForm.Location = new System.Drawing.Point(panel1.Width+100);
            this.panel3.Controls.Add(childForm);
            //this.panelDesktopPanel.Controls.Add(childForm);
            // this.panelDesktopPanel.Tag = childForm;
            this.panel3.Tag = childForm;

            childForm.BringToFront();

            childForm.Show();
            //title.Text = childForm.Text;
        }

        private void InsBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form1());

        }

        private void coursesBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form2());

        }

        private void ExamBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form3());

        }

        private void St_Grades_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form5());

        }

        private void St_Track_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form6());

        }

        private void St_Answers_Btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form4());

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
