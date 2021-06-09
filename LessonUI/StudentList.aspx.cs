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
    public partial class StudentList : System.Web.UI.Page
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
                List<Student> studentList = bll.GetAllStudent();
                StringBuilder sb = new StringBuilder();
                int count = 1;
                sb.Append("<center><div backgrount-color : #f0f0f0'><table border = '1px; solid'><tr><th>编号</th><th>学号</th><th>姓名</th><th>班级</th><th>学科</th><th>年龄</th><th>电话</th><th>性别</th><th>操作</th></tr>");

                foreach (var item in studentList)
                {
                    sb.AppendFormat("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td><td>{4}</td><td>{5}</td><td>{6}</td><td>{7}</td><td><a href = 'DeleteStudent.ashx?ID={8}'>删除</a><a href = 'UpdateStudent.aspx?ID={8}'> 修改</a></td><td><img style='width:60px; height:60px' src = './Picture/{3}/{1}.jpg'></td></tr>", count++, item.StuNum, item.StuName, item.StuClass, item.Subject, item.StuAge, item.StuPhone, item.StuGender, item.ID);

                }
                sb.Append("<tr><td colspan = '9'><a href = 'AddStudent.aspx'>添加用户</a></td></tr></center>");
                sb.Append("<tr><td colspan = '9'><a href = 'SearchStudentFromScope.aspx'>学号范围查找用户</a></td></tr></table></center>");
                Response.Write(sb.ToString());
            }

        }
    }
}