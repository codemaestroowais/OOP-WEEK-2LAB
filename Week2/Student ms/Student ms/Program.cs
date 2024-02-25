using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_ms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentManager studentManager = new StudentManager();

            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Show Students");
                Console.WriteLine("3. Calculate Aggregate");
                Console.WriteLine("4. Top Students");
                Console.WriteLine("5. Exit");

                int choice = int.Parse(Console.ReadLine());

                if(choice == 1)
                {
                    studentManager.AddStudent();
                }
               else if (choice == 2)
                {
                    studentManager.ShowStudents();
                }
               else if (choice == 3)
                {
                    studentManager.CalculateAggregate();
                }
               else if (choice == 4)
                {
                    studentManager.TopStudents();
                }
            }
        }
    }

    class Student
    {
        public string Name;
        public double MatricMarks;
        public double FscMarks;
        public double EcatMarks;

        public Student(string name, double matricMarks, double fscMarks, double ecatMarks)
        {
            Name = name;
            MatricMarks = matricMarks;
            FscMarks = fscMarks;
            EcatMarks = ecatMarks;
        }

        public double CalculateAggregate()
        {
            return (MatricMarks + FscMarks + EcatMarks) / 3;
        }
    }

    class StudentManager
    {
        private List<Student> students = new List<Student>();

        public void AddStudent()
        {
            Console.WriteLine("Enter Student Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Matric Marks:");
            double matricMarks = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Fsc Marks:");
            double fscMarks = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Ecat Marks:");
            double ecatMarks = double.Parse(Console.ReadLine());

            Student newStudent = new Student(name, matricMarks, fscMarks, ecatMarks);
            students.Add(newStudent);

            Console.WriteLine("Student added successfully!");
        }

        public void ShowStudents()
        {
            Console.WriteLine("\nList of Students:");
            foreach (var student in students)
            {
                Console.WriteLine($"Name: {student.Name}, Matric Marks: {student.MatricMarks}, Fsc Marks: {student.FscMarks}, Ecat Marks: {student.EcatMarks}");
            }
            Console.WriteLine();
        }

        public void CalculateAggregate()
        {
            double totalAggregate = 0;

            foreach (var student in students)
            {
                totalAggregate += student.CalculateAggregate();
            }

            double averageAggregate = totalAggregate / students.Count;

            Console.WriteLine($"Average Aggregate: {averageAggregate}\n");
        }

        public void TopStudents()
        {
            var topThreeStudents = students.OrderByDescending(s => s.CalculateAggregate()).Take(3);

            Console.WriteLine("\nTop 3 Students:");

            foreach (var student in topThreeStudents)
            {
                Console.WriteLine($"Name: {student.Name}, Aggregate: {student.CalculateAggregate()}");
            }

            Console.WriteLine();
        }
    }
    
}
