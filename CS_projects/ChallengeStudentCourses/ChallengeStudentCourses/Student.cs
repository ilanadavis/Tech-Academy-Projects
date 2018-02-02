using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeStudentCourses
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public List<Course> Courses { get; set; }

        public Student()
        {
            this.StudentId = 0;
            this.Name = "Name";
            this.Courses = Courses;
        }

        //Overloaded constructor
        public Student(int studentid, string name, List<Course> Course)
        {
            this.StudentId = studentid;
            this.Name = name;
            this.Courses = Courses;
        }

        public string FormatDetailsForDisplay()
        {
            return String.Format("&nbsp&nbspStudent: 1 - {0}<br/>", this.Name);
        }
    }
}