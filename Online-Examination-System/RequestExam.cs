﻿using Online_Examination_System.Models;
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
    public partial class RequestExam : Form
    {
        Student student;
        OnlineExaminatonSystemContext db;
        public RequestExam(Student _student, OnlineExaminatonSystemContext _db)
        {
            InitializeComponent();
            db = _db;
            student = _student;
            this.BackColor = Color.Lavender;
        }

        private void RequestExam_Load(object sender, EventArgs e)
        {

        }
    }

}
