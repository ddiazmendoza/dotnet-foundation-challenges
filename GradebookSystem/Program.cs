using System;
using System.Collections.Generic;

namespace GradebookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("How many students?: ");
            int n = int.Parse(Console.ReadLine()); // Number of students

            System.Console.WriteLine("How many tests?: ");
            int tests = int.Parse(Console.ReadLine()); // Number of tests

            List<Student> Students = new List<Student>();

            for (var i = 1; i <= n; i++)
            {
                Console.WriteLine($"Name of student |{i}|?:");
                var studentName = Console.ReadLine();
                Console.WriteLine($"Last name of student |{i}|");
                var lastName = Console.ReadLine();

                Student newStudent = new Student(studentName, lastName);
                newStudent.LetterGrades
               

                for (var j = 1; j <= tests; j++)
                {
                    var numericalGrade = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Test |{j}| numerical grade:");
                    newStudent.NumericalGrades.Add();   
                }

                Students.Add(newStudent);
            }
            System.Console.WriteLine("Gradebook System:");
            foreach (var student in Students)
            {
                student.Print();
            }

            

        }
    }
    
    
    
}
