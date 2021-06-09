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
    public partial class AddStudent : System.Web.UI.Page
    {   
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["UserName"] == null)
            //    Response.Redirect("UserLogin.aspx");
        }
        private StudentBll bll = new StudentBll();

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string stuNum = txtStuNum.Text.Trim();
            if (bll.selectCount(stuNum))
            {
                Response.Write("<script>alert('学号重复')</script>");
            }
            else
            {
                Student stu = new Student();
               
                stu.StuNum = txtStuNum.Text.Trim();
                stu.StuName = txtStuName.Text.Trim();
                stu.StuClass = txtStuClass.Text.Trim();
                stu.Subject = txtSubject.Text.Trim();
                stu.StuPhone = txtStuPhone.Text.Trim();
                stu.StuPwd = txtStuPwd.Text.Trim();
                int age = 0;
                if (int.TryParse(txtStuAge.Text.Trim(), out age) == false)
                    stu.StuAge = age;
                else
                    stu.StuAge = age;
                stu.StuGender = rbMale.Checked ? "男" : "女";
                if (FileUpload1.HasFile)
                {
                    string fileExtension = System.IO.Path.GetExtension(FileUpload1.FileName).ToLower();
                    if (IsImage(fileExtension))
                    {
                        string picPath = "./Picture/" + stu.StuClass + "/" + stu.StuNum + ".jpg";
                        string Path = Server.MapPath(picPath);
                        FileUpload1.PostedFile.SaveAs(Path);
                    }

                }
                if (bll.InsertStudent(stu))
                {
                    Response.Write("<script>alert('修改成功')</script>");
                }
                else
                {
                    Response.Write("<script>alert('修改出错')</script>");
                }
            
            }

        }
        public bool IsImage(string str)
        {
            bool isimage = false;
            string thestr = str.ToLower();
            //限定只能上传jpg和gif图片
            string[] allowExtension = { ".jpg", "gif" };
            //对上传的文件的类型进行一个个匹对
            for (int i = 0; i < allowExtension.Length; i++)
            {
                if (thestr == allowExtension[i])
                {
                    isimage = true;
                    break;
                }
            }
            return isimage;
        }
        protected void btnClear_Click(object sender, EventArgs e)
        {
            
        }
    }
}