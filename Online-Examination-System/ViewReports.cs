using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Online_Examination_System;

namespace Online_Examination_System
{
    public partial class ViewReports : Form
    {
        public ViewReports()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();

            f1.Show();
        }

        private void ViewReports_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();

            f2.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();

            f3.Show();
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();

            f4.Show();
        }
        private void button5_Click_1(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();

            f5.Show();
        }
        private void button6_Click_1(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();

            f6.Show();
        }

       

    }
}
