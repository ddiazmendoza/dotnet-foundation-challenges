using System.Collections.Generic;

public class Student 
    {
        public enum Grades {A, B, C, D, F};
        
        public string Name { get; set; }
        
        public string LastName { get; set; }

        public List<int> NumericalGrades {get; set;}

        public List<Grades> LetterGrades {get; set;}
        

        public Student(string name, string lastName, List<int> numGrades)
        {
            Name = name; 
            LastName = lastName;
            NumericalGrades = numGrades;
            LetterGrades = CalculateLetterGrades();
            
        }
        public List<Grades> CalculateLetterGrades() 
        {
            var letterG = new List<Grades>();
            var n = this.NumericalGrades;
            for (var i = 1; i <= n.Count; i++)
            {
                if (n[i] >= 0 && n[i] <= 59) 
                {
                    letterG.Add(Grades.F);
                }
                else if (n[i] >= 60 && n[i] <= 69) 
                {
                    letterG.Add(Grades.D);
                }
                else if (n[i] >= 70 && n[i] <= 79) 
                {
                    letterG.Add(Grades.C);
                }
                else if (n[i] >= 80 && n[i] <= 89) 
                {
                    letterG.Add(Grades.B);
                }
                else if (n[i] >= 90 && n[i] <= 100) 
                {
                    letterG.Add(Grades.A);
                }
            }
            return letterG;
        }
        public void Print() 
        {
 
            System.Console.WriteLine(this.Name);
            System.Console.WriteLine(this.LastName);

            for (var i = 0; i <= NumericalGrades.Count; i++)
            {
                System.Console.Write($"| {NumericalGrades[i].ToString()} |");
                // System.Console.WriteLine($"| {LetterGrades[i].ToString()} |");
            }
        }
        
    }