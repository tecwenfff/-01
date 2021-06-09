using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Model;
using LessonBll;
using System.Web.SessionState;

namespace LessonUI
{
    /// <summary>
    /// UpdateStudent1 的摘要说明
    /// </summary>
    public class UpdateStudent1 : IHttpHandler, IRequiresSessionState
    {
        StudentBll bll = new StudentBll();
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            //context.Response.Write("Hello World");
            if (context.Session["UserName"] == null)
                context.Response.Redirect("/UserLogin.aspx");
            else
            {
                string id = context.Request.QueryString["ID"];
                if (string.IsNullOrEmpty(id))
                    context.Response.Redirect("/UserLogin.aspx");
                else
                {
                    Student stu = bll.selectStudent(Convert.ToInt32(id));
                    bll.UpdateStudent(stu);
                }
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