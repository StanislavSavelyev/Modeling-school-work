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
            public List<Student> Students { get; set; }
            public School(string name)
            {
                Name = name;
                Students = new List<Student>();
            }

            public void PrintStudents()
            {
                if (Students.Count == 0)
                {
                    Console.WriteLine($"В школе {Name} пока что нету учеников");
                }
                else
                {
                    foreach (Student student in Students)
                    {
                        Console.WriteLine("{0, -10} {1, -10}", student.FistName, student.LastName);
                    }

                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте, введите название школы.");
            string SchoolName = Console.ReadLine();
            var School = new School(SchoolName);
            Console.WriteLine($"Школа {School.Name} успешно создана.");
            while (true)
            {
                Console.WriteLine($"Хотите посмотреть список всех студентов школы {School.Name}? Введите Да или Нет");
                string userAnswer = Console.ReadLine().ToLower();
                if (userAnswer == "да")
                {
                    School.PrintStudents();
                }
            }
        }
    }
}
