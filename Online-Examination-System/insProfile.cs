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
            if (instractor.Ins_ID != null)
                lbl_insID.Text = instractor.Ins_ID.ToString();
            else 
                lbl_insID.Text = "undefined";
            if (instractor.FName != null)
                txt_fname.Text = instractor.FName;
            else 
                txt_fname.Text = "undefined";
            if (instractor.LName != null)
                txt_lname.Text = instractor.LName;
            else 
                txt_lname.Text = "undefined";

            if (instractor.Working_Hours != null)
                txt_whours.Text = instractor.Working_Hours.ToString();
            else 
                txt_whours.Text =  "undefined";
            if (instractor.Address != null)
                txt_addr.Text = instractor.Address;
            else 
                txt_addr.Text = "undefined";
            if (instractor.Birthdate != null)
                txt_birth.Text = $"{instractor.Birthdate.Value.Year}-{instractor.Birthdate.Value.Month}-{instractor.Birthdate.Value.Day}";
            else 
                txt_birth.Text = "undefined";
            //txt_birth.Text = instractor.Birthdate.ToString();
        }
        private void btn_back_Click(object sender, EventArgs e)
        {
            instructorDashboard instructorDashboard = new instructorDashboard(instractor, db);
            this.Hide();
            instructorDashboard.FormClosed += (obj, args) => this.Close(); ;
            instructorDashboard.Show();
        }

        private void txt_lname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
