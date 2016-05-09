using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UI.Models
{
    public class ModelToView
    {
        public ModelToView()
        {
            this.student = new Student();
            this.teacher =new Teacher();
            this.team = new Team();
            this.teamGrade = new TeamGrade();
            this.personalGrade = new PersonalGrade();
            this.course = new Course();
            this.gradeItem = new GradeItem();
        }
        public Course course { get; set; }
        public Student student { get;set; }
        public Teacher teacher { get; set; }
        public Team team { get; set; }
        public TeamGrade teamGrade { get; set; }
        public PersonalGrade personalGrade { get; set; }
        public GradeItem gradeItem { get; set; }
    }
    
}