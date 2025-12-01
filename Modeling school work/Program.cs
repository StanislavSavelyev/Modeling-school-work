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

        static void Main(string[] args)
        {
        }
    }
}
