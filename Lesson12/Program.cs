using System;
using System.IO;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
namespace Lesson12
{
    class Program
    {
        const string DirectoryPath = @"C:\Users\22\Pictures\Camera Roll";

        static void Main(string[] args)
        {
            PrintStudents(GetStudents());
        }
        public static Student CreateStudent()
        {
            Student student = new Student();
            Console.WriteLine("Create new student info: ");
            Console.WriteLine("");
            Console.WriteLine("Student name : ");
            student.name = Console.ReadLine();
            Console.WriteLine("Student surname : ");
            student.surname = Console.ReadLine();
            Console.WriteLine("Student age : ");
            student.age = byte.Parse(Console.ReadLine());
            Console.WriteLine("Student unikal id : ");
            student.studentid = int.Parse(Console.ReadLine());
            return student;
        }

        public static void RegisterStudentAsFile(Student student)
        {
            var filepath = Path.Combine(DirectoryPath, student.studentid + ".txt");
            if (File.Exists(filepath))
            {
                Console.WriteLine("This student already registr");
            }
            else
            {
                string filetext = $"Name : {student.name} \n" +
                    $"Surname : {student.surname}\n" +
                    $"age : {student.age}";
                File.WriteAllText(filepath, filetext);
            }
        }

        public static Student[] GetStudents()
        {
            var directory = new DirectoryInfo(DirectoryPath);
            var files = directory.GetFiles();

            var students = new Student[100];

            var i = 0;

            foreach (var file in files)
            {
                var fileLines = File.ReadAllLines(file.FullName);
                var student = new Student();
                student.name = fileLines[0].Split(':')[1].Trim();
                student.surname = fileLines[1].Split(':')[1].Trim();
                student.age = byte.Parse(fileLines[2].Split(':')[1].Trim());

                students[i] = student;
                i++;
            }

            return students;
        }

        public static void PrintStudents(Student[] students)
        {
            foreach (var student in students)
            {
                if (student is null)
                {
                    break;
                }

                PrintStudent(student);

                Console.WriteLine();
                Console.WriteLine("---------------------");
                Console.WriteLine();
            }
        }

        public static void PrintStudent(Student student)
        {
            Console.WriteLine($"{nameof(student.name)}: {student.name}");
            Console.WriteLine($"{nameof(student.surname)}: {student.surname}");
        }

    }
    class Student
    {
        public int studentid { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public byte age { get; set; }
    }
}
