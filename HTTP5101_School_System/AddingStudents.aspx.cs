using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HTTP5101_School_System
{
    public partial class AddingStudents : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                Page.Validate();
                if (Page.IsValid)
                {
                    string Student_Fname = student_fname.Text.ToString();
                    string Student_Lname = student_lname.Text.ToString();
                    string Student_Number = student_number.Text.ToString();

                    AddingSummary.InnerHtml = "";
                    AddingSummary.InnerHtml = "You have added the following student:" + "<br>";
                    AddingSummary.InnerHtml = "First name: " + Student_Fname + "<br>";
                    AddingSummary.InnerHtml = "Last name:" + Student_Lname + "<br>";

                }
            }
    }
}