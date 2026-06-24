using System;
using System.Collections.Generic;

namespace StudentResultsSystem
{
    class Program
    {
        static List<Student> students = new List<Student>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("===== STUDENT RESULTS PROCESSING SYSTEM =====");
                Console.WriteLine("1. Enter Student Results");
                Console.WriteLine("2. View Student Report");
                Console.WriteLine("3. Exit");
                Console.Write("Choose an option: ");
                
                string option = Console.ReadLine();
                Console.WriteLine(); // spacing

                if (option == "1")
                {
                    EnterStudentResults();
                }
                else if (option == "2")
                {
                    ViewStudentReport();
                }
                else if (option == "3")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option. Please try again.\n");
                }
            }
        }

        static void EnterStudentResults()
        {
            int studentNum = students.Count + 1;
            Console.WriteLine($"Enter details for Student {studentNum}");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Student ID: ");
            string id = Console.ReadLine();

            Console.Write("Programme: ");
            string programme = Console.ReadLine();

            Console.Write("Level: ");
            string levelInput = Console.ReadLine();
            int level = int.TryParse(levelInput, out int l) ? l : 100;

            int[] courses = new int[5];
            for (int i = 0; i < 5; i++)
            {
                while (true)
                {
                    Console.Write($"Course {i + 1} Score: ");
                    if (int.TryParse(Console.ReadLine(), out int score) && score >= 0 && score <= 100)
                    {
                        courses[i] = score;
                        break;
                    }
                    Console.WriteLine("Invalid score. Enter a value between 0 and 100.");
                }
            }

            students.Add(new Student(name, id, programme, level, courses));
            Console.WriteLine("Student results successfully added!\n");
        }

        static void ViewStudentReport()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No student records available.\n");
                return;
            }

            foreach (var student in students)
            {
                Console.WriteLine("============================");
                Console.WriteLine($"Name: {student.Name}");
                Console.WriteLine($"ID: {student.Id}");
                Console.WriteLine($"Programme: {student.Programme}");
                Console.WriteLine($"Level: {student.Level}");
                Console.WriteLine($"Course 1: {student.Courses[0]}");
                Console.WriteLine($"Course 2: {student.Courses[1]}");
                Console.WriteLine($"Course 3: {student.Courses[2]}");
                Console.WriteLine($"Course 4: {student.Courses[3]}");
                Console.WriteLine($"Course 5: {student.Courses[4]}");
                Console.WriteLine($"Total: {student.Total}");
                Console.WriteLine($"Average: {student.Average:F1}");
                Console.WriteLine($"Grade: {student.Grade}");
                Console.WriteLine($"Status: {student.Status}");
            }
            Console.WriteLine();
        }
    }

    class Student
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public string Programme { get; set; }
        public int Level { get; set; }
        public int[] Courses { get; set; }

        public int Total { get; private set; }
        public double Average { get; private set; }
        public string Grade { get; private set; }
        public string Status { get; private set; }

        public Student(string name, string id, string programme, int level, int[] courses)
        {
            Name = name;
            Id = id;
            Programme = programme;
            Level = level;
            Courses = courses;
            CalculateResults();
        }

        private void CalculateResults()
        {
            int sum = 0;
            foreach (var score in Courses)
            {
                sum += score;
            }
            Total = sum;
            Average = sum / 5.0;

            if (Average >= 80) Grade = "A";
            else if (Average >= 75) Grade = "B+";
            else if (Average >= 70) Grade = "B";
            else if (Average >= 65) Grade = "C+";
            else if (Average >= 60) Grade = "C";
            else if (Average >= 55) Grade = "D+";
            else if (Average >= 50) Grade = "D";
            else Grade = "F";

            Status = Average >= 50 ? "Passed" : "Failed";
        }
    }
}
