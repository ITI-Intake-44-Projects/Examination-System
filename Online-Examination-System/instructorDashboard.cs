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
    public partial class instructorDashboard : Form
    {
        Instructor instructor;
        OnlineExaminatonSystemContext db;
        public instructorDashboard(Instructor _instructor, OnlineExaminatonSystemContext _db)
        {
            InitializeComponent();
            db = _db;
            instructor = _instructor;
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.FormClosed += (obj, args) => this.Close(); ;
            login.Show();
        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            insProfile insProfile = new insProfile(instructor, db);
            this.Hide();
            insProfile.FormClosed += (obj, args) => this.Close(); ;
            insProfile.Show();
        }

        private void coursesBtn_Click(object sender, EventArgs e)
        {
            insCourses ins_Course = new insCourses(instructor, db);
            this.Hide();
            ins_Course.FormClosed += (obj, args) => this.Close(); ;
            ins_Course.Show();
        }

        private void questionBtn_Click(object sender, EventArgs e)
        {
            insQuestions ins_Q = new insQuestions(instructor, db);
            this.Hide();
            ins_Q.FormClosed += (obj, args) => this.Close(); ;
            ins_Q.Show();
        }
    }
}
