using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using Model;
using LessonBll;

namespace LessonUI
{
    /// <summary>
    /// DeleteStudent 的摘要说明
    /// </summary>
    public class DeleteStudent : IHttpHandler, IRequiresSessionState
    {
        StudentBll bll = new StudentBll();
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            //context.Response.Write("Hello World");
            if (context.Session["UserName"] == null)
            {
                context.Response.Redirect("/UserLogin.aspx");
            }
            else
            {
                int id = Convert.ToInt32(context.Request.QueryString["ID"]);
                bll.deleteStudent(id);
                context.Response.Write("<script>alert('学生删除成功')</script>");
                context.Response.Redirect("/StudentList.aspx");
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}