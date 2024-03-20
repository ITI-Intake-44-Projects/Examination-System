using Microsoft.Reporting.WinForms;
using System.Data;
using System.Data.SqlClient;

namespace AbdElfattah
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=OnlineExaminationSystemDB;Integrated Security=True;Encrypt=False");
        private void button1_Click(object sender, EventArgs e)
        {
            //try
            //{
                SqlCommand command = new SqlCommand("GetCoursesAndStudentCountByInstructorID_Report", con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@InstructorID", textBox1.Text);

              //  command.Parameters.AddWithValue("@StudentID", textBox2.Text);


                SqlDataAdapter d = new SqlDataAdapter(command);
                DataTable dt = new DataTable();

                d.Fill(dt);
                reportViewer1.LocalReport.DataSources.Clear();
                ReportDataSource source = new ReportDataSource("DataSet1", dt);
                reportViewer1.LocalReport.ReportPath = "./ReportDefintions/Report1.rdlc";
                reportViewer1.LocalReport.DataSources.Add(source);
                reportViewer1.RefreshReport();
            //}
            //catch (SqlException ex)
            //{
            //    // Display error message to the user
            //    MessageBox.Show("An error occurred while fetching data. Please insert valid data and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }
    }
}

