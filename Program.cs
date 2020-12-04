using System;
using Student_Registration.Classes;

namespace Student_Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();

            Console.Write("Please type student´s name:  ");
            student1.name = Console.ReadLine();
            Console.WriteLine();
            
            Console.Write("Please type student´s course: ");
            student1.course = Console.ReadLine();
            Console.WriteLine();
            
            Console.Write("Please type student´s age: ");
            student1.age = int.Parse(Console.ReadLine());
            Console.WriteLine();
            
            Console.Write("Please type student´s id: ");
            student1.id = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Is the student a scholarship owner? [yes = y] [no = n]\n");
            string answer = Console.ReadLine().ToLower();

            if (answer == "y") { 

                student1.scholarship = true;
            }

            else if (answer == "n") {

                student1.scholarship = false;
            }

            Console.WriteLine();
            Console.Write("Please type student´s final grade: ");
            student1.finalGrade = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Please type student´s monthly payment: $");
            student1.monthlyPayment = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Clear();
        
            Console.WriteLine(student1.name);
            Console.WriteLine();
            Console.WriteLine(student1.course);
            Console.WriteLine();
            Console.WriteLine(student1.age);
            Console.WriteLine();
            Console.WriteLine(student1.id);
            Console.WriteLine();
            
            student1.ShowFinalGrade(student1.finalGrade);
            Console.WriteLine();
            student1.ShowPayment(student1.scholarship, student1.monthlyPayment);
        
        }
    }
}
