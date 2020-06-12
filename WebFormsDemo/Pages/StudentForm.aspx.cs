using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

namespace WebFormsDemo.Pages
{
    public partial class StudentForm : System.Web.UI.Page
    {
        private static List<Student> Student = new List<Student>();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected Exception GetInnerException(Exception ex)
        {
            while (ex.InnerException != null)
            {
                ex = ex.InnerException;
            }
            return ex;
        }
        protected void ShowMessage(string message, string cssclass)
        {
            MessageLabel1.Attributes.Add("class", cssclass);
            MessageLabel1.InnerHtml = message;
        }
        protected bool Validation(object sender, EventArgs e)
        {
            int id = 0;
            if (string.IsNullOrEmpty(ID.Text))
            {
                ShowMessage("ID is required", "alert alert-info");
                return false;
            }
            string input1 = ID.Text;
            if (input1.Length < 4 || input1.Length > 4)
            {
                ShowMessage("ID must be four non 0 digit long", "alert alert-info");
                return false;
            }
            Match match1 = Regex.Match(input1, @"[1-9][1-9][1-9][1-9]$");
            if (!match1.Success)
            {
                ShowMessage("ID must be four non 0 digit long", "alert alert-info");
                return false;
            }
            if (string.IsNullOrEmpty(Name.Text))
            {
                ShowMessage("Name is required", "alert alert-info");
                return false;
            }
            if (string.IsNullOrEmpty(Credits.Text))
            {
                ShowMessage("Credits is required", "alert alert-info");
                return false;
            }
            double input3 = double.Parse(Credits.Text);
            if (input3 < 0.00 || input3 > 40.00)
            {
                ShowMessage("Credits must be between 0.00 and 40.00", "alert alert-info");
                return false;
            }
            if (string.IsNullOrEmpty(Phone.Text))
            {
                ShowMessage("Phone Number is required", "alert alert-info");
                return false;
            }
            string input2 = Phone.Text;
            Match match2 = Regex.Match(input2, @"[1-9][0-9][0-9][-][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]$");
            if (!match2.Success)
            {
                ShowMessage("Phone Number must be like 123-123-1234", "alert alert-info");
                return false;
            }
            return true;
        }
        protected void Add_Click(object sender, EventArgs e)
        {
            var isValid = Validation(sender, e);
            if (isValid)
            {
                bool found = false;
                foreach (var item in Student)
                {
                    if (item.ID == int.Parse(ID.Text))
                    {
                        found = true;
                    }
                }
                if (found)
                {
                    ShowMessage("Record already exists.", "alert alert-info");
                }
                else
                {
                    Student newitem = new Student(int.Parse(ID.Text), Name.Text, double.Parse(Credits.Text), Phone.Text);
                    Student.Add(newitem);
                    EmployeeGridView.DataSource = Student;
                    EmployeeGridView.DataBind();
                    ShowMessage("Record added.", "alert alert-success");
                }
            }
        }
        protected void Clear_Click(object sender, EventArgs e)
        {
            ID.Text = "";
            Name.Text = "";
            Phone.Text = "";
            Credits.Text = "";
        }
    }
}