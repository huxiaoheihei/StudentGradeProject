using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class GradeItem
    {
        public int GradeItemId { get; set; }
        public string GradeItemName { get; set; }
        public string Wight { get; set; }
        public string PerOrTeam { get; set; }

        public virtual List<PersonalGrade> PersonalGrades { get; set; }
        public virtual List<TeamGrade> TeamGrades { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
