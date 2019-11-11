using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HTTP5101_School_System
{
    public partial class ListTeachers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string query = "select * from teachers";
            var db = new SCHOOLDB();
            List<Dictionary<String, String>> rs = db.List_Query(query);
            foreach (Dictionary<String, String> row in rs)
            {
                teachers_list.InnerHtml += "<div class=\"listitem\">";

                string teacherfirstname = row["TEACHERFNAME"];
                teachers_list.InnerHtml += "<div class=\"col5\">" + teacherfirstname + "</div>";

                string teacherlastname = row["TEACHERLNAME"];
                teachers_list.InnerHtml += "<div class=\"col5\">" + teacherlastname + "</div>";

               string employeenumber = row["EMPLOYEENUMBER"];
                teachers_list.InnerHtml += "<div class=\"col5\">" + employeenumber + "</div>";

                string hiredate = row["HIREDATE"];
                teachers_list.InnerHtml += "<div class=\"col5\">" + hiredate + "</div>";

                string salary = row["SALARY"];
                teachers_list.InnerHtml += "<div class=\"col5last\">" + salary + "</div>";


                teachers_list.InnerHtml += "</div>";
            }
        }
    }
}