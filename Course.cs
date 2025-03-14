using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseInfo
{
    internal class Course
    {
        protected string Name;
        protected string Subject;
        List<Student> Students = new List<Student>();

        public string GetName()
        { return Name; }
        public string GetSubject() { return Subject; }
        public void SetName(string name)
        {
            Name = name;
        }
        public void SetSubject(string subject) {
            Subject = subject; 
        }
        public void AddStudent(Student student)
        {
            Students.Add(student);
        }
        public void RemoveStudent(int i)
        {
            Students.RemoveAt(i);
        }
        public Student UpdateStudent(int i, string studentId, string studentName)
        {
            Students[i].SetStudentId(studentId);
            Students[i].SetStudentName(studentName);
            return Students[i];
        }

        public void DisplayCourse()
        {
            Console.WriteLine("Course Name: {0}", GetName());
            Console.WriteLine("Course Subject: {0}", GetSubject());
            Console.WriteLine("Lists of students:");
            foreach(Student item in Students)
            {
                item.DisplayStudent();
            }
        }

        public Course()
        {
            SetName("Default Course Name");
            SetSubject("Default Subject");
        }
        public Course(string name, string subject)
        {
            SetName(name);
            SetSubject(subject);
        }
    }
}
