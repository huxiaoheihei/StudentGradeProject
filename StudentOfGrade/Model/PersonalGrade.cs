using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class PersonalGrade
    {
        public int PersonalGradeId { get; set; }
        public int Pgrade { get; set; }

        public virtual Student Student { get; set; }
        public virtual GradeItem GradeItem { get; set; }
    }
}
