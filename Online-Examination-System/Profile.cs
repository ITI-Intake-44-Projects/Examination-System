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
        }
    }
}
