using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;
using System.Data.SqlClient;
namespace LessonDal
{
    public class UserLoginDal
    {
        public UserLogin1 SelectUserLogin(String UserName)
        {
            String sql = "select * from Userlogin1 where UserName=@UserName";
            SqlParameter para = new SqlParameter("@UserName", UserName);
            UserLogin1 user = null;
            SqlConnection con=new SqlConnection ("Server=localhost;Database=note;Trusted_Connection=yes");
            using(SqlDataReader reader = SqlDbHelper.ExecuteReader(sql,CommandType.Text,con,para))
            {
                if (reader.Read()) 
                {
                    user = new UserLogin1();
                    user.id = reader.GetInt32(0);
                    user.UserName = reader.GetString(1);
                    user.pwd = reader.GetString(2);
                    user.Lv = reader.GetInt32(3);
                }
            }
            return user;
        }
        public Student1 SelectStudentLogin(String StuName, string Pwd)
        {
            String sql = "select * from Student where Stunum=@StuNum and Pwd=@Pwd";
            SqlParameter[] para = { new SqlParameter("@StuNum", StuName), new SqlParameter("@Pwd", Pwd) };
            Student1 user = null;
            SqlConnection con = new SqlConnection("Server=localhost;Database=note;Trusted_Connection=yes");
            using (SqlDataReader reader = SqlDbHelper.ExecuteReader(sql, CommandType.Text, con, para))
            {
                if (reader.Read())
                {
                    user = new Student1();
                    user.ID = reader.GetInt32(0);
                    user.StuNum = reader.GetString(1);
                    user.StuName = reader.GetString(2);
                    user.StuClass = reader.GetString(3);
                    user.Subject = reader.GetString(4);
                    user.StuAge = reader.GetInt32(5);
                    user.StuPhone = reader.GetString(6);
                    user.StuGender = reader.GetString(7);
                    user.Pwd = reader.GetString(8);
                }
            }
            return user;
        }
        public int updateUserLogin(string UserName, string Pwd)
        {
            string sql = "update UserLogin1 set pwd = @pwd where UserName = @UserName";

            SqlDbHelper sh = new SqlDbHelper();



            return sh.ExecuteNonquery(sql, CommandType.Text, new SqlParameter("@UserName", UserName), new SqlParameter("@pwd", Pwd));
            
        }
    }
}
