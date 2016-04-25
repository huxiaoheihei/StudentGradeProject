using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class TeamGrade
    {
        public int TeamGradeId { get; set; }
        public int Tgrade { get; set; }

        public virtual Team Team { get; set; }
        public virtual GradeItem GradeItem { get; set; }
    }
}
