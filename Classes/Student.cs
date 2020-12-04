using System;
namespace Student_Registration.Classes
{
    public class Student
    {
        public string name;
        public string course;
        public int age;
        public string id;
        public bool scholarship;
        public double finalGrade;
        public double monthlyPayment;
        
        public void ShowFinalGrade(double grade) {

            Console.WriteLine($"The final grade of the student is: {grade}");

        }

        public void ShowPayment(bool scholarship, double monthlyPayment) {

            if (scholarship == true) {

                Console.WriteLine();
                Console.WriteLine("Student has gained scholarship");
                Console.WriteLine();
                Console.WriteLine($"Monthly Payment without scholarship:$ {monthlyPayment}");
                Console.WriteLine();
                Console.WriteLine($"Monthly Payment with scholarship:$ {0.7 * monthlyPayment}");
            } 
                
            else {
                
                Console.WriteLine();
                Console.WriteLine("Student has not gained scholarship");
                Console.WriteLine();
                Console.WriteLine($"Monthly Payment:$ {monthlyPayment}"); 
            }

        }
    }
}