using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeStudentCourses
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public List<Student> Students { get; set; }

        public Course()
        {
            this.CourseId = 0;
            this.Name = "Name";
            this.Students = Students;
        }

        //Overloaded constructor
        public Course(int courseid, string name, List<Student> Students)
        {
            this.CourseId = courseid;
            this.Name = name;
            this.Students = Students;
        }


        public string FormatDetailsForDisplay()
        {
            return String.Format("Course: 1 - {0} {1}<br/>", this.Name, this.CourseId);
        }
    }    
}