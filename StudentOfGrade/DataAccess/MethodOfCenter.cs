using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using Model.Repository;

namespace DataAccess
{
    public class MethodOfCenter
    {
        private GradeRp gradeRp = new GradeRp();

        public IEnumerable<Course> Courses()
        {
            return gradeRp.Courses;
        }

        public IEnumerable<GradeItem> GradeItems()
        {
            return gradeRp.GradeItems;
        }

        public IEnumerable<PersonalGrade> PersonalGrades()
        {
            return gradeRp.PersonalGrades;
        }

        public IEnumerable<TeamGrade> TeamGrades()
        {
            return gradeRp.TeamGrades;
        }

        public IEnumerable<Team> Teams()
        {
            return gradeRp.Teams;
        }

        public IEnumerable<Student> Students()
        {
            return gradeRp.Students;
        }

        public int GetIdByTeaName(string name)
        {
            return gradeRp.GetIdByTeaName(name);
        }

        public Teacher GetUserByTeacherId(int uid)
        {
            return gradeRp.GetUserByTeacherId(uid);
        }

        public int Add(GradeItem gradeItem)
        {
            return gradeRp.Add(gradeItem);
        }
    }
}
