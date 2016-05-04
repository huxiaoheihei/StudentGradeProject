using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Repository
{
    public class GradeRp
    {
        private StudentOfGradeContext sgContext = new StudentOfGradeContext();

        public IQueryable<GradeItem> GradeItems
        {
            get { return sgContext.GradeItems; }
        }

        public IQueryable<PersonalGrade> PersonalGrades
        {
            get { return sgContext.PersonalGrades; }
        }

        public IQueryable<TeamGrade> TeamGrades
        {
            get { return sgContext.TeamGrades; }
        }

        public IQueryable<Student> Students
        {
            get { return sgContext.Students; }
        }

        public IQueryable<Team> Teams
        {
            get { return sgContext.Teams; }
        }

        public IQueryable<Course> Courses
        {
            get { return sgContext.Courses; }
        }

        public Teacher GetById(int id)
        {
            return sgContext.Set<Teacher>()
                .Where(t => t.TeacherId == id)
                .FirstOrDefault();
        }

        public int Add(GradeItem gradeItem)
        {
            sgContext.Set<GradeItem>().Add(gradeItem);
            return sgContext.SaveChanges();
        }

        public int GetIdByTeaName(string name)
        {
            int uid = sgContext.Teachers.Where(t => t.TrealName == name).FirstOrDefault().TeacherId;
            return uid;
        }
        //通过上面找到的id 找到该人model
        public Teacher GetUserByTeacherId(int uid)
        {
            return sgContext.Teachers.Find(uid);
        }
    }
}
