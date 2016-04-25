using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Team
    {
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public virtual List<Student> Students { get; set; }
        public virtual List<TeamGrade> TeamGrades { get; set; }
    }
}
