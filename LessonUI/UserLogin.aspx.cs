using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LessonBll;
using Model;

namespace LessonUI
{
    public partial class UserLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                    
        }
        UserLoginBll bll = new UserLoginBll();

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text.Trim();
            string pwd = txtPwd.Text.Trim();

            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(pwd))
            {
                Response.Write("<script> alert('用户名和密码不能为空') </script>");
            }
            else if (RadioButton1.Checked)
            {
                UserLogin1 user = bll.GetUerLogin(userName);
                if (user != null)
                {
                    if (pwd == user.pwd.Trim())
                    {
                        Session["UserName"] = user.UserName;
                        this.Response.Write("<script>alert('成功');</script>");
                        if (user.Lv == 0)
                            Response.Redirect("/StudentList.aspx?UserName=" + userName);
                        else if (user.Lv == 1)
                            Response.Redirect("/ListView.aspx?UserName=" + userName);
                    }
                    else
                    {
                        
                        this.Response.Write("<script>alert('密码不正确');</script>");
                    }
                }
                else
                {
                    this.Response.Write("<script>alert('用户不存在');</script>");
                }
            }
            else if (RadioButton2.Checked)
            {
                Student1 stu = bll.SelectStudentLogin(userName, pwd);
                if (stu != null)
                {
                    Session["UserName"] = stu.StuName;
                    Response.Redirect("/StudentPage.aspx?UserName=" + stu.StuClass);
                    
                }

            }
        }

    }
}