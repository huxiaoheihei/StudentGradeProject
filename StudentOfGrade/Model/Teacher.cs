using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;
namespace Model
{
  public  class Teacher
    {
      public int TeacherId { get; set; }
     
      public string TuserName { get; set; }
      public string TpassWord { get; set; }
      public string TrealName { get; set; }
      public string Tcontent { get; set; }
      public string Trole { get; set; }

      public virtual List<Student> Students { get; set; }
      public virtual List<Course> Courses { get; set; }
      public virtual List<GradeItem> GradeItems { get; set; }

    }
}
