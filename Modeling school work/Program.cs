using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using static Modeling_school_work.Program;

namespace Modeling_school_work
{
    internal class Program
    {

        public class Student
        {
            public string FistName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public Student(string firstName, string lastName, int age)
            {
                FistName = firstName;
                LastName = lastName;
                Age = age;
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
                    Console.WriteLine("{0, -5} {1, -10} {2, -10} {3, -10}", "ID", "Имя", "Фамилия", "Возраст");
                    for (int i = 0; i < Students.Count; i++)
                    {
                        Console.WriteLine("{0, -5} {1, -10} {2, -10} {3, -10}", i + 1, Students[i].FistName, Students[i].LastName, Students[i].Age);
                    }
                }
            }
            public void AddNewStudent(Student student)
            {
                Students.Add(student);
                Console.WriteLine($"Студент {student.FistName} {student.LastName} успешно добавлен в школу {Name}");
            }

            public void RemoveStudent(int id)
            {
                try
                {
                    Students.RemoveAt(id - 1);
                }
                catch
                {
                    Console.WriteLine("Студента с таким ID не существует");
                }
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
                    Console.WriteLine("Введите возраст ученика");
                    int age = Convert.ToInt32(Console.ReadLine());

                    var student = new Student(firstName, lastName, age);
                    school.AddNewStudent(student);
                }

                Console.WriteLine($"Хотите удалить ученика из школы {school.Name}? Введите Да или Нет");
                userAnswer = Console.ReadLine().ToLower();
                if (userAnswer == "да")
                {
                    Console.WriteLine("Введите ID ученика которого желаете удалить");
                    int id = Convert.ToInt32(Console.ReadLine());

                    school.RemoveStudent(id);
                }
            }
        }
    }
}
