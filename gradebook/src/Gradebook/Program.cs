using System;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the School Application");
            Console.WriteLine("Please enter the student first name: ");
            var first = Console.ReadLine();
            Console.WriteLine("Please enter the student last name: ");
            var last  = Console.ReadLine();
            Console.WriteLine("Please enter the student grade: ");
            var grade = int.Parse(Console.ReadLine());

            MemoryBook book = new MemoryBook(first, last, grade);

            while(true){
                Console.WriteLine($"Enter a grade for student {book.FirstName} or q to end..");
                var number = Console.ReadLine();

                if(number == "q"){
                    break;
                }

                try{
                    var studentGrade = double.Parse(number);
                    book.AddGrade(studentGrade);
                }
                catch(ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch(FormatException e){
                    Console.WriteLine(e.Message);
                }
            }

            book.PerformAnalytics();
        }
    }
}
