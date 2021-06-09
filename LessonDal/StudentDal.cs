using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Model;

namespace LessonDal
{
    public class StudentDal
    {
        public List<Student> GetAllStudent()
        {
            SqlConnection con = new SqlConnection("Server=localhost;Database=note;Trusted_Connection=yes");
            string sql = "select * from Student";
            List<Student> studentList = new List<Student>();
            using (SqlDataReader reader = SqlDbHelper.ExecuteReader(sql, CommandType.Text, con, null))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Student stu = new Student();
                        stu.ID = reader.GetInt32(0);
                        stu.StuNum = reader.GetString(1);
                        stu.StuName = reader.GetString(2);
                        stu.StuClass = reader.GetString(3);
                        stu.Subject = reader.GetString(4);
                        stu.StuAge = Convert.IsDBNull(reader[5]) ? null : (int?)reader.GetInt32(5);
                        stu.StuPhone = reader.GetString(6);
                        stu.StuGender = reader.GetString(7);
                        studentList.Add(stu);
                    }
                }
            }
            return studentList;
        }
        public List<Subject> studentGetSubject(string StuClass)
        {
            SqlConnection con = new SqlConnection("Server=localhost;Database=note;Trusted_Connection=yes");
            string sql = "select * from Subject where StuClass = @StuClass";
            
            List<Subject> subjectList = new List<Subject>();
            using (SqlDataReader reader = SqlDbHelper.ExecuteReader(sql, CommandType.Text, con, new SqlParameter("@StuClass", StuClass)))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Subject stu = new Subject();
                        stu.SubjectID = reader.GetInt32(0);
                        stu.TeacherID = reader.GetInt32(1);
                        stu.SubjectName = reader.GetString(2);
                        stu.StuClass = reader.GetString(3);
                        subjectList.Add(stu);
                    }
                }
            }
            return subjectList;
        }

        public List<Student> GetAllStudentToScope(int min, int max)
        {
            SqlConnection con = new SqlConnection("Server=localhost;Database=note;Trusted_Connection=yes");
            string sql = "select * from Student where (StuNum > @min) and (StuNum < @max) order by StuNum asc;";
            SqlParameter[] ps = { new SqlParameter("@min", min), new SqlParameter("@max", max) };
            List<Student> studentList = new List<Student>();
            using (SqlDataReader reader = SqlDbHelper.ExecuteReader(sql, CommandType.Text, con, ps))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Student stu = new Student();
                        stu.ID = reader.GetInt32(0);
                        stu.StuNum = reader.GetString(1);
                        stu.StuName = reader.GetString(2);
                        stu.StuClass = reader.GetString(3);
                        stu.Subject = reader.GetString(4);
                        stu.StuAge = Convert.IsDBNull(reader[5]) ? null : (int?)reader.GetInt32(5);
                        stu.StuPhone = reader.GetString(6);
                        stu.StuGender = reader.GetString(7);
                        stu.StuPwd = "";
                        studentList.Add(stu);
                    }
                }
            }
            return studentList;
        }
        public int UpDateStudent(Student stu)
        {
            string sql = "update Student set StuNum = @StuNum, StuName = @StuName, StuClass = @StuClass, Subject = @Subject, StuAge = @StuAge, StuPhone = @StuPhone, StuGender = @StuGender where ID = @ID";
            SqlDbHelper sh = new SqlDbHelper();
            int b = sh.ExecuteNonquery(sql, CommandType.Text, new SqlParameter("@StuNum", stu.StuNum), new SqlParameter("@StuName", stu.StuName), new SqlParameter("@StuClass", stu.StuClass), new SqlParameter("@Subject", stu.Subject), new SqlParameter("@StuAge", stu.StuAge), new SqlParameter("@StuPhone", stu.StuPhone), new SqlParameter("@StuGender", stu.StuGender), new SqlParameter("@ID", stu.ID));
            return b;
        }
        public Student selectStudent (int id)
        {
            string sql = "select * from Student where ID = @ID";
            SqlDbHelper sh = new SqlDbHelper();
            DataTable dt = sh.ExecuteDataTable(sql, CommandType.Text, new SqlParameter("@ID", id));
            Student stu = new Student();
            stu.ID = id;
            stu.StuNum = dt.Rows[0]["StuNum"].ToString();
            stu.StuName = dt.Rows[0]["StuName"].ToString();
            stu.StuClass = dt.Rows[0]["StuClass"].ToString();
            stu.Subject = dt.Rows[0]["Subject"].ToString();
            stu.StuAge = dt.Rows[0]["StuAge"] == DBNull.Value ? 0 : (int)dt.Rows[0]["StuAge"];
            stu.StuPhone = dt.Rows[0]["StuPhone"].ToString();
            stu.StuGender = dt.Rows[0]["StuGender"].ToString();

            return stu;
        }
        public int selectCount(string stuNum, int id)
        {
            string sql = "select count(*) from Student where StuNum = @StuNum and ID != @ID";
            SqlDbHelper sh = new SqlDbHelper();
            int b = (int)sh.ExecuteScalar(sql, CommandType.Text, new SqlParameter("@StuNum", stuNum), new SqlParameter("@ID", id));
            return b;
        }
        public int selectCount(string stuNum)
        {
            string sql = "select count(*) from Student where StuNum = @StuNum";
            SqlDbHelper sh = new SqlDbHelper();
            int b = (int)sh.ExecuteScalar(sql, CommandType.Text, new SqlParameter("@StuNum", stuNum));
            return b;
        }
        public int InsertStudent(Student stu)
        {
            string sql = "insert into Student values (@StuNum, @StuName, @StuClass, @Subject, @StuAge, @StuPhone, @StuGender, @Pwd)";
            SqlParameter[] param = { new SqlParameter("@StuNum", stu.StuNum), new SqlParameter("@StuName", stu.StuName), new SqlParameter("@StuClass", stu.StuClass), new SqlParameter("@Subject", stu.Subject), new SqlParameter("@StuAge", stu.StuAge), new SqlParameter("@StuPhone", stu.StuPhone), new SqlParameter("@StuGender", stu.StuGender), new SqlParameter("@Pwd", stu.StuPwd) };
            SqlDbHelper sh = new SqlDbHelper();
            int b = sh.ExecuteNonquery(sql, CommandType.Text, param);
            return b;
        }
        public int deleteStudent(int id)
        {
            string sql = "delete from Student where ID = @id";
            SqlDbHelper sh = new SqlDbHelper();
            int b = sh.ExecuteNonquery(sql, CommandType.Text, new SqlParameter("@id", id));
            return b;
        }
    }
}
