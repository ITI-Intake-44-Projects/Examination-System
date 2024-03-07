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
            db  = _db;
            instructor = _instructor;
        }
    }
}
