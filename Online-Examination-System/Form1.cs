using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Online_Examination_System.Models;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using System.Diagnostics;

namespace Online_Examination_System
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form exam = new Exam();
            exam.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form prev = new PreviousExams();
            prev.ShowDialog();
        }
    }
}
