using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.Reporting.WinForms;
using System.Data;
using System.Data.SqlClient;

namespace Online_Examination_System
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=OnlineExaminationSystemDB;Integrated Security=True;Encrypt=False");
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("GetCourseTopics", con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Crs_ID", textBox1.Text);

                //  command.Parameters.AddWithValue("@StudentID", textBox2.Text);


                SqlDataAdapter d = new SqlDataAdapter(command);
                DataTable dt = new DataTable();

                d.Fill(dt);
                reportViewer1.LocalReport.DataSources.Clear();
                ReportDataSource source = new ReportDataSource("DataSet2", dt);
                reportViewer1.LocalReport.ReportPath = "D:\\المنحه\\V5\\Online-Examination-System\\ReportDefintions\\Report2.rdlc";
                reportViewer1.LocalReport.DataSources.Add(source);
                reportViewer1.RefreshReport();
            }
            catch (SqlException ex)
            {
                // Display error message to the user
                MessageBox.Show("An error occurred while fetching data. Please insert valid data and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }
    }



}

