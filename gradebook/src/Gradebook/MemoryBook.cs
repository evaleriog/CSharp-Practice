using System;

namespace Gradebook{
    public class MemoryBook : Student, IBook{
        private Analytics allGrades;
        public MemoryBook(string fname, string lname, int grade) : base(fname, lname, grade){
            allGrades = new Analytics();
        }
        public void AddGrade(double grade){
            if(grade > 0 && grade <= 100){
                allGrades.Add(grade);
            }
            else{
                throw new ArgumentException($"Invalid argument on {nameof(grade)}");
            }
        }

        public void PerformAnalytics(){
            Console.WriteLine($"The report card for {LastName}, {FirstName} in {Grade} grade:");
            Console.WriteLine($"The higuest grade was : {allGrades.High}");
            Console.WriteLine($"The lowest grade was : {allGrades.Low}");
            Console.WriteLine($"The average is {allGrades.Average:N2}");
            Console.WriteLine($"The final grade is {allGrades.LetterGrade}");
        }
    }
}