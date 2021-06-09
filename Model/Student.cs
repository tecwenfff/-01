using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Student
    {
        public int ID { set; get; }
        public string StuNum { set; get; }
        public string StuName { set; get; }
        public string StuClass { set; get; }
        public string Subject { set; get; }
        public int? StuAge { set; get; }
        public string StuPhone { set; get; }
        public string StuGender { set; get; }
        public string StuPwd { set; get; }
    }
}
