using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Model
{
  public  class Teacher
    {
      public int TeacherID { get; set; }
      [MaxLength(10)]
      public string Tname { get; set; }

    }
}
