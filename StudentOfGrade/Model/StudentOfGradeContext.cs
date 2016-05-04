using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Model
{
   public class StudentOfGradeContext:DbContext
    {
       public DbSet<Student> Students { get; set; }

       public DbSet<Teacher> Teachers { get; set; }

       public DbSet<Team> Teams { get; set; }

       public DbSet<Course> Courses { get; set; }
       
       public DbSet<GradeItem> GradeItems { get; set; }

       public DbSet<PersonalGrade> PersonalGrades { get; set; }

       public DbSet<TeamGrade> TeamGrades { get; set; }
    }
}
