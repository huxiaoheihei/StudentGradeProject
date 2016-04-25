using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Cname { get; set; }

        //public virtual List<Student> Students { get; set; }
        public virtual List<Teacher> Teachers { get; set; }
    }
}
