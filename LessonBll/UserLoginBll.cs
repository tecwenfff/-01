using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using LessonDal;
namespace LessonBll
{
    public class UserLoginBll
    {
        UserLoginDal dal = new UserLoginDal();
        public UserLogin1 GetUerLogin(String userName)
        {
            return dal.SelectUserLogin(userName);//当前业务简单 略去业务处理
        }
        public bool updateUserLogin(string UserName, string Pwd)
        {
            return dal.updateUserLogin(UserName, Pwd) == 1;
        }
        public Student1 SelectStudentLogin(String StuName, string Pwd)
        {
            return dal.SelectStudentLogin(StuName, Pwd);
        }
    }
}
