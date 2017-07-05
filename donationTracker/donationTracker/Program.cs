using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace donationTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Your Donation Tracker!");
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();

            Console.WriteLine("What is your address?");
            string yourAddress = Console.ReadLine();

            Console.WriteLine("How many 1s are you donating?");
            int ones = int.Parse(Console.ReadLine());
            int onesInDollars = ones * 1;

            Console.WriteLine("How many 5s are you donating?");
            int fives = int.Parse(Console.ReadLine());
            int fivesInDollars = fives * 5;

            Console.WriteLine("How many 10s are you donating?");
            int tens = int.Parse(Console.ReadLine());
            int tensInDollars = tens * 10;

            int donationAmount = (onesInDollars + fivesInDollars + tensInDollars);
            Console.WriteLine("Your Donation Total Was $" + donationAmount);
            Console.WriteLine("Thank you for your donation");
            
        }
    }
}
