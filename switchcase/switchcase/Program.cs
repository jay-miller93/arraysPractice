using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcase
{
    class Program
    {
        static void Main(string[] args)
        {
            string loyaltyLevel = "red";
            switch (loyaltyLevel)
            {
                case "yellow":
                    Console.WriteLine("Discount : 40%");
                    break;
                case "red":
                    Console.WriteLine("Discount : 90");
                    break;
                default:
                    Console.WriteLine("error");
                    break;

            }
        }
    }
}
