using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseInfo
{
    internal class Student
    {
        protected string StudentId;
        protected string StudentName;

        public string GetStudentId()
        {
            return StudentId;
        }
        public string GetStudentName() { return StudentName; }
        public void SetStudentId(string studentId)
        {
            StudentId = studentId;
        }
        public void SetStudentName(string studentName)
        {
            StudentName = studentName;
        }
        public void DisplayStudent()
        {
            Console.WriteLine("Student ID: {0}, Student Name: {1}",GetStudentId(),GetStudentName());
        }
        public Student()
        {
            SetStudentId("Default Student ID");
            SetStudentName("Default Student Name");
        }
        public Student(string studentId, string studentName)
        {
            SetStudentId(studentId);
            SetStudentName(studentName);
        }
    }
}
