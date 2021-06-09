using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using LessonDal;
using Model;

namespace LessonBll
{
    public class StudentBll
    {
        private StudentDal dal = new StudentDal();
        public List<Student> GetAllStudent()
        {
            return dal.GetAllStudent().Count > 0 ? dal.GetAllStudent() : null;
        }
        public List<Subject> studentGetSubject(string StuClass)
        {
            return dal.studentGetSubject(StuClass);
        }

        public bool UpdateStudent(Student stu)
        {
            return dal.UpDateStudent(stu) > 0;
        }
        public Student selectStudent(int id)
        {
            return dal.selectStudent(id);
        }
        public bool selectCount(string stuNum, int id)
        {
            return dal.selectCount(stuNum, id) >= 1;
        }
        public bool selectCount(string stuNum)
        {
            return dal.selectCount(stuNum) >= 1;
        }
        public bool InsertStudent(Student stu)
        {
            return dal.InsertStudent(stu) == 1;
        }
        public bool deleteStudent(int id)
        {
            return dal.deleteStudent(id) == 1;
        }
        public List<Student> GetAllStudentToScope(int min, int max)
        {
            return dal.GetAllStudentToScope(min, max);
        }
    }
}
