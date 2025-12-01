using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

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
                FistName = firstName;
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
                    Console.WriteLine("{0, -10} {1, -10}", "Имя", "Фамилия");
                    foreach (Student student in Students)
                    {
                        Console.WriteLine("{0, -10} {1, -10}", student.FistName, student.LastName);
                    }
                }
            }
            public void AddNewStudent(Student student)
            {
                Students.Add(student);
                Console.WriteLine($"Студент {student.FistName} {student.LastName} успешно добавлен в школу {Name}");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте, введите название школы.");
            string schoolName = Console.ReadLine();
            var school = new School(schoolName);
            Console.WriteLine($"Школа {school.Name} успешно создана.");
            while (true)
            {
                Console.WriteLine($"Хотите посмотреть список всех студентов школы {school.Name}? Введите Да или Нет");
                string userAnswer = Console.ReadLine().ToLower();
                if (userAnswer == "да")
                {
                    school.PrintStudents();
                }

                Console.WriteLine($"Хотите добавить нового ученика в школу {school.Name}? Введите Да или Нет");
                userAnswer = Console.ReadLine().ToLower();
                if (userAnswer == "да")
                {
                    Console.WriteLine("Введите имя ученика");
                    string firstName = Console.ReadLine();
                    Console.WriteLine("Введите фамилию ученика");
                    string lastName = Console.ReadLine();

                    var student = new Student(firstName, lastName);
                    school.AddNewStudent(student);
                }
            }
        }
    }
}
