﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeStudentCourses
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                        
        }

        protected void assignment1Button_Click(object sender, EventArgs e)
        {
            
            string result = "";

            Course course1 = new Course() { CourseId = 1, Name = "Math - 101", Students = null };
            Course course2 = new Course() { CourseId = 2, Name = "Math - 202", Students = null };
            Course course3 = new Course() { CourseId = 3, Name = "English - 102", Students = null };

            Student student1 = new Student() { StudentId = 1, Name = "Billy Joe", Courses = new List<Course> { course1, course2 } };
            Student student2 = new Student() { StudentId = 2, Name = "Don Johnson", Courses = new List<Course> { course1, course3 } };
            Student student3 = new Student() { StudentId = 3, Name = "Sally Smith", Courses = new List<Course> { course2, course3 } };

            course1.Students = new List<Student> { student1, student2 };
            course2.Students = new List<Student> { student1, student3 };
            course3.Students = new List<Student> { student2, student3 };


            List<Course> courses = new List<Course>()
            {
                course1, course2, course3,
            };

            List<Student> students = new List<Student>()
            {
                student1, student2, student3,
            };
            
            foreach (Course course in courses)
            {
                result += course.FormatDetailsForDisplay();
                foreach (Student student in course.Students)
                {
                    result += student.FormatDetailsForDisplay();
                }
            }
            
            resultLabel.Text = result;
      
            /*
             * Create a List of Courses (add three example Courses ...
             * make up the details).  Each Course should have at least two
             * Students enrolled in them.  Use Object and Collection
             * Initializers.  Then, iterate through each Course and print
             * out the Course's details and the Students that are enrolled in
             * each Course.
             */
        }

        protected void assignment2Button_Click(object sender, EventArgs e)
        {

            Course course1 = new Course() { CourseId = 1, Name = "Math - 101", Students = null };
            Course course2 = new Course() { CourseId = 2, Name = "Math - 202", Students = null };
            Course course3 = new Course() { CourseId = 3, Name = "English - 102", Students = null };


            Dictionary<string, Student> students = new Dictionary<string, Student>();
            students.Add("1", new Student { Name = "Billy Joe", Courses = new List<Course> { course1, course2 } });
            students.Add("2", new Student { Name = "Don Johnson", Courses = new List<Course> { course1, course3 } });
            students.Add("3", new Student { Name = "Sally Smith", Courses = new List<Course> { course2, course3 } });


            foreach (var student in students)
            {
                resultLabel.Text += String.Format("Student: {1} - {0}<br/>", student.Value.Name, student.Key);
                foreach (var course in student.Value.Courses)
                {
                    resultLabel.Text += String.Format("&nbsp;&nbsp;Course: {0} {1}<br/>", course.CourseId, course.Name);
                }
            }
        }

        /*
         * Create a Dictionary of Students (add three example Students
         * ... make up the details).  Use the StudentId as the 
         * key.  Each student must be enrolled in two Courses.  Use
         * Object and Collection Initializers.  Then, iterate through
         * each student and print out to the web page each Student's
         * info and the Courses the Student is enrolled in.
         */
         

        protected void assignment3Button_Click(object sender, EventArgs e)
        {
            Course course1 = new Course() { CourseId = 1, Name = "Math - 101", Students = null, };
            Course course2 = new Course() { CourseId = 2, Name = "Math - 202", Students = null };
            Course course3 = new Course() { CourseId = 3, Name = "English - 102", Students = null };
            List<Course> courses = new List<Course>()
            {
                course1, course2, course3,
            };


            Student student1 = new Student() { StudentId = 1, Name = "Billy Joe", Courses = new List<Course> { course1, course2} };
            Student student2 = new Student() { StudentId = 2, Name = "Don Johnson", Courses = new List<Course> { course1, course3 } };
            Student student3 = new Student() { StudentId = 3, Name = "Sally Smith", Courses = new List<Course> { course2, course3 } };
            List<Student> students = new List<Student>()
            {
                student1, student2, student3,
            };

            Grades grade1 = new Grades() { Grade = 89, Course = course1, Student = student1 };
            Grades grade2 = new Grades() { Grade = 78, Course = course2, Student = student1 };
            Grades grade3 = new Grades() { Grade = 98, Course = course1, Student = student2 };
            Grades grade4 = new Grades() { Grade = 97, Course = course3, Student = student2 };
            Grades grade5 = new Grades() { Grade = 73, Course = course2, Student = student3 };
            Grades grade6 = new Grades() { Grade = 88, Course = course3, Student = student3 };
            List<Grades> grades = new List<Grades>()
            {
                grade1, grade2, grade3, grade4, grade5, grade6,
            };


            student1.Grades = new List<Grades> { grade1, grade2 };
            student2.Grades = new List<Grades> { grade3, grade4 };
            student3.Grades = new List<Grades> { grade5, grade6 };


            foreach (Student student in students)
            {
                resultLabel.Text += String.Format("Student: {0} {1}<br/>", student.StudentId, student.Name);
                foreach (Course course in student.Courses)
                {
                    resultLabel.Text += String.Format("&nbsp;&nbsp;Enrolled In: {0} - ", course.Name);
                    foreach (Grades grade in student.Grades)
                    {
                        if (grade.Course == course)
                        {
                            resultLabel.Text += String.Format("Grade: {0}<br/>", grade.Grade);
                        }
                    }
                }
                
            }

            
            /*
             * We need to keep track of each Student's grade (0 to 100) in a 
             * particular Course.  This means at a minimum, you'll need to add 
             * another class, and depending on your implementation, you will 
             * probably need to modify the existing classes to accommodate this 
             * new requirement.  Give each Student a grade in each Course they
             * are enrolled in (make up the data).  Then, for each student, 
             * print out each Course they are enrolled in and their grade.
             */
        }

    }
}