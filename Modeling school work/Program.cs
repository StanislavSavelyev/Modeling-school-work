using System.Security.Cryptography.X509Certificates;

namespace Modeling_school_work
{
    internal class Program
    {

        public class Student
        {
            public string FistName { get; set; }
            public string LastName { get; set; }
            public Student(string firstName, string lastName)
            {
                firstName = firstName;
                LastName = lastName;
            }
        }
        public class School
        {
            public string Name { get; set; }
            public List<Student> Students { get; set; } = new List<Student>();
            public School(string name, Student student)
            {
                Name = name;
                Students.Add(student);
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
