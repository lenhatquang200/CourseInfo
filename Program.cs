namespace CourseInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Day la 2 cach khai bao Course, cach 1: khai bao ra doi tuong Course, sau do set cac gia tri
            //Course course = new Course();
            //course.SetName("SP25 - SE08101");
            //course.SetSubject("Programming");
            //  cach 2: khai bao ra doi tuong Course va cac gia tri ngay tai do/.
            Course course = new Course("P25 - SE08101", "Programming");

            Student student1 = new Student();
            Student student2 = new Student("BC0001","Nguyen Van A");
            Student student3 = new Student("BC0002","Nguyen Van B");
            Student student4 = new Student("BC0003","Nguyen Van C");

            course.AddStudent(student1);
            course.AddStudent(student2);
            course.AddStudent(student3);
            course.AddStudent(student4);
            course.DisplayCourse();
            Console.WriteLine("--------------------");

            course.UpdateStudent(1, "BC9999", "Tran Thi D");
            course.DisplayCourse();
            Console.WriteLine("--------------------");

            course.RemoveStudent(0);
            course.DisplayCourse();
        }
    }
}
