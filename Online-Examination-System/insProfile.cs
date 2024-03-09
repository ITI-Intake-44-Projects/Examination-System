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
    public partial class insProfile : Form
    {
        Instructor instractor;
        OnlineExaminatonSystemContext db;
        public insProfile(Instructor _instractor, OnlineExaminatonSystemContext _db)
        {
            InitializeComponent();
            // to share the instractor data when show the form
            instractor = _instractor;
            //to share the database connection
            db = _db;

            lbl_insID.Text = instractor.Ins_ID.ToString();
            txt_fname.Text = instractor.FName;
            txt_lname.Text = instractor.LName;
            txt_whours.Text = instractor.Working_Hours.ToString();
            txt_addr.Text = instractor.Address;
            txt_birth.Text = instractor.Birthdate.ToString();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            instructorDashboard instructorDashboard = new instructorDashboard(instractor, db);
            this.Hide();
            instructorDashboard.FormClosed += (obj, args) => this.Close(); ;
            instructorDashboard.Show();
        }
    }
}
