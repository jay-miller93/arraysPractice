using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            //{//First problem
            //    double firstNumber;
            //    double secondNumber;
            //    Console.WriteLine("Please input your first numer.");
            //    firstNumber = double.Parse(Console.ReadLine());

            //    Console.WriteLine("Please input  your second number.");
            //    secondNumber = double.Parse(Console.ReadLine());

            //    if (firstNumber == secondNumber)
            //    {
            //        Console.WriteLine("The number " + firstNumber + " and " + secondNumber + " are the same.");

            //    }
            //    else
            //    {
            //        Console.WriteLine("The numbers " + firstNumber + " and " + secondNumber + " are not equal to each other");
            //    }
            //fizz buzz
            

            Console.WriteLine("Please enter a test number");
            int test = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a Fizz number between 1 and 9");
            int Fizz = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a Buzz number between 1 and 9");
            int Buzz = int.Parse(Console.ReadLine());

            if (test / Fizz == Buzz && test / Buzz == Fizz)
            {
                Console.WriteLine("FIZZBUZZ!");

            }

            if (test % Fizz == 0)
            {
                Console.WriteLine("FIZZ!");
            }
            if (test % Buzz == 0 )
            {
                Console.WriteLine("BUZZ!");
            }
            else
            {
                Console.WriteLine(" The number is " + test);

            }


        }
    }
}
