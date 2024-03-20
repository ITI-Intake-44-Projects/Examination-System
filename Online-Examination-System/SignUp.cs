using Microsoft.VisualBasic.Logging;
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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            nextBtn.BackColor = Color.FromArgb(92, 184, 92);
            backBtn.BackColor = Color.FromArgb(52, 152, 219);
            List<string> roles = new List<string> { "Choose your role", "Student", "Instructor" };
            role_cb.DataSource = roles;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            CloseAndShowForm(login);
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            Person person = new Person(firstname: firstname_txt.Text, lastname: lastname_txt.Text, address: address_txt.Text, username: username_txt.Text, password: password_txt.Text, role: role_cb.SelectedValue.ToString(), date: datePicker.Value);
            if (validateData(person))
            {
                var result = MessageBox.Show("Are you sure you want to sign up?", "sign up in progress", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    if (person.role == "Student")
                    {
                        Student student = new Student
                        {
                            Fname = person.firstname,
                            Lname = person.lastname,
                            UserName = person.username,
                            Passowrd = person.password,
                            Address = person.address,
                            BirthDate = person.date,
                        };
                        CompleteSignUpAsStudent signUpAsStudent = new CompleteSignUpAsStudent(student);
                        CloseAndShowForm(signUpAsStudent);
                    }
                    else
                    {
                        Instructor instructor = new Instructor
                        {
                            FName = person.firstname,
                            LName = person.lastname,
                            Username = person.username,
                            Password = person.password,
                            Address = person.address,
                            Birthdate = person.date,
                        };
                        try
                        {
                            OnlineExaminatonSystemContext db = new OnlineExaminatonSystemContext();
                            db.Add(instructor);
                            db.SaveChanges();
                            instructorDashboard dashboard = new instructorDashboard(instructor, db);
                            CloseAndShowForm(dashboard);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Something went wrong!", "sign up failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    SignUp signUp = new SignUp();
                    CloseAndShowForm(signUp);
                    MessageBox.Show("sign up as soon as possible :)", "sign up failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                var result = MessageBox.Show("please fill all data", "sign up interupted", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Cancel)
                {
                    emptyFields();
                    MessageBox.Show("let we see u again ):", "sign up wasn't completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Login login = new Login();
                    CloseAndShowForm(login);
                }
            }
        }

        #region Helper Functions
        private void emptyFields()
        {
            firstname_txt.Text = ""; lastname_txt.Text = ""; username_txt.Text = "";
            address_txt.Text = ""; password_txt.Text = ""; role_cb.SelectedIndex = -1;
            datePicker.Value = DateTime.Now;
        }

        private bool validateData(Person person)
        {
            return (firstname_txt.Text != "" && lastname_txt.Text != "" && username_txt.Text != "" &&
                    address_txt.Text != "" && password_txt.Text != "" && role_cb.SelectedIndex != 0 &&
                    datePicker.Value != null);
        }

        private void CloseAndShowForm(Form formToShow)
        {
            this.Hide();
            formToShow.FormClosed += (obj, args) => this.Close();
            formToShow.Show();
        }
        #endregion

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
    public class Person
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string address { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string role { get; set; }
        public DateTime date { get; set; }
        public Person(string firstname, string lastname, string address, string username, string password, string role, DateTime date)        
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.username = username;
            this.password = password;
            this.address = address;
            this.role = role;
            this.date = date;
        }
    }
}
