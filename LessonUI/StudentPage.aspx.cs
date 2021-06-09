using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LessonBll;
using Model;

namespace LessonUI
{
    public partial class StudentPage : System.Web.UI.Page
    {
        private StudentBll bll = new StudentBll();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserName"] == null)
            {
                Response.Redirect("/UserLogin.aspx");
            }
            else
            {
                List<Subject> subjectList = bll.studentGetSubject(Request.QueryString["UserName"]);
                StringBuilder sb = new StringBuilder();
                sb.Append("<center><div backgrount-color : #f0f0f0'><table border = '1px; solid'><tr><th>编号</th><th>课程名</th><th>班级</th></tr>");

                foreach (var item in subjectList)
                {
                    sb.AppendFormat("<tr><td>{0}</td><td>{1}</td><td>{2}</td></tr>", item.SubjectID, item.SubjectName, item.StuClass);

                }
                
                Response.Write(sb.ToString());
            }
        }
    }
}