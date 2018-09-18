using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_inclass2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 for factorial or 2 for Tower of Hanoi");
            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                Factorial factorial = new Factorial();

                Console.WriteLine("Solve 5!");
                Console.Write("The answer is: ");
                // 33 will overflow and give a negative answer
                Console.WriteLine(factorial.SolveFactorial(5));
            }
        }
    }
}
