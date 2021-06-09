using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using LessonBll;

namespace LessonUI
{
    public partial class UpdateStudent : System.Web.UI.Page
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
                if (!this.IsPostBack)
                {
                    string id = Request.QueryString["ID"];
                    if (string.IsNullOrEmpty(id))
                    {
                        Response.Write("<script>alert('数据错误')</script>");
                    }
                    else
                    {
                        Student stu = bll.selectStudent(Convert.ToInt32(id));
                        lblId.Text = stu.ID.ToString();
                        txtStuNum.Text = stu.StuNum;
                        txtStuName.Text = stu.StuName;
                        txtStuClass.Text = stu.StuClass;
                        txtSubject.Text = stu.Subject;
                        txtStuAge.Text = stu.StuAge == null ? "" : stu.StuAge.ToString();
                        txtStuPhone.Text = stu.StuPhone;
                        rbMale.Checked = stu.StuGender == "男";
                        rbFemale.Checked = stu.StuGender == "女";
                    }
                }
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string stuNum = txtStuNum.Text.Trim();
            if (bll.selectCount(stuNum, Convert.ToInt32(lblId.Text)))
            {
                Response.Write("<script>alert('学号重复')</script>");
            }
            else
            {
                Student stu = new Student();
                stu.ID = Convert.ToInt32(lblId.Text);
                stu.StuNum = txtStuNum.Text.Trim();
                stu.StuName = txtStuName.Text.Trim();
                stu.StuClass = txtStuClass.Text.Trim();
                stu.Subject = txtSubject.Text.Trim();
                stu.StuPhone = txtStuPhone.Text.Trim();
                int age = 0;
                if (int.TryParse(txtStuAge.Text.Trim(), out age) == false)
                    stu.StuAge = age;
                else
                    stu.StuAge = age;
                stu.StuGender = rbMale.Checked ? "男" : "女";
                if (bll.UpdateStudent(stu))
                {
                    Response.Write("<script>alert('修改成功')</script>");
                }
                else
                {
                    Response.Write("<script>alert('修改出错')</script>");
                }
            }
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {

        }
    }
}