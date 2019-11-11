using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//make sure your final project has these
using MySql.Data.MySqlClient;
using System.Diagnostics;


namespace HTTP5101_School_System
{
    public partial class ListStudents : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*
                An alternate way to fetch data without the SCHOOLDB.cs class
                https://dev.mysql.com/doc/connector-net/en/connector-net-tutorials-sql-command.html
            */

            string query = "select * from students";
            var db = new SCHOOLDB();
            List<Dictionary<String,String>> rs = db.List_Query(query);
            foreach(Dictionary<String,String> row in rs)
            {
                students_result.InnerHtml += "<div class=\"listitem\">";

                string studentfirstname = row["STUDENTFNAME"];
                students_result.InnerHtml += "<div class=\"col5\">" + studentfirstname + "</div>";

                string studentlastname = row["STUDENTLNAME"];
                students_result.InnerHtml += "<div class=\"col5\">" + studentlastname + "</div>";

                string studentnumber = row["STUDENTNUMBER"];
                students_result.InnerHtml += "<div class=\"col5\">" + studentnumber + "</div>";

                string enrolmentdate = row["ENROLMENTDATE"];
                students_result.InnerHtml += "<div class=\"col5\">" + enrolmentdate + "</div>";   
                students_result.InnerHtml += "<div class=\"col5last\">" + "Update, Delete, View" + "</div>";
                students_result.InnerHtml += "</div>";
            }
            

        }
    }
}