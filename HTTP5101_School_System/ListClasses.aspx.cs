using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HTTP5101_School_System
{
    public partial class ListClasses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string query = "select * from classes";
            var db = new SCHOOLDB();
            List<Dictionary<String, String>> rs = db.List_Query(query);
            foreach (Dictionary<String, String> row in rs)
            {
                classes_list.InnerHtml += "<div class=\"listitem\">";

                string classcode = row["CLASSCODE"];
                classes_list.InnerHtml += "<div class=\"col6\">" + classcode + "</div>";

                string teacherid = row["TEACHERID"];
                classes_list.InnerHtml += "<div class=\"col6\">" + teacherid + "</div>";

                string startdate = row["STARTDATE"];
                classes_list.InnerHtml += "<div class=\"col6\">" + startdate + "</div>";

                string finishdate = row["FINISHDATE"];
                classes_list.InnerHtml += "<div class=\"col6\">" + finishdate + "</div>";

                string classname = row["CLASSNAME"];
                classes_list.InnerHtml += "<div class=\"col6\">" + classname + "</div>";

                string view = row["CLASSID"];
                classes_list.InnerHtml += "<div class=\"col6last\">" + view + "</div>";




                classes_list.InnerHtml += "</div>";
            }
        }
    }
}