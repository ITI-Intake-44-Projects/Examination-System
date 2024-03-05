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
    public partial class supervisorDashboard : Form
    {
        Track trackSupervisor;
        OnlineExaminatonSystemContext db;
        public supervisorDashboard(Track _trackSupervisor, OnlineExaminatonSystemContext _db)
        {
            InitializeComponent();
            db = _db;
            trackSupervisor = _trackSupervisor;
        }
    }
}
