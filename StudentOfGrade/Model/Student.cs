using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Sname { get; set; }
        public string Sclass { get; set; }
        public string Smajor { get; set; }
        public string Srole { get; set; }

        //public virtual List<Course> Courses { get; set; }
        public virtual List<Teacher> Teachers { get; set; }
        public virtual Team Team { get; set; }
        public virtual List<PersonalGrade> PersonalGrades { get; set; }
    }
}
