using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraypractice
{
    class Program
    {
        static void Main(string[] args)
        {
            ////declaring array without initializing
            //int[] myFirstArray;
            ////declaring and initializing a second array
            //string[] myStringArray = { "First", "Second", "Third", "Fourth" };
            ////declare and initialize a char array with the letters of your last name
            //char[] myLastName = { 'M', 'i', 'l', 'L', 'e', 'r'};
            //// i want my console to print three elements of my array
            //Console.WriteLine(myLastName[0]);
            //Console.WriteLine(myLastName[3]);
            //Console.WriteLine(myLastName[1]);

            ////create following arrays and print using the correct index numbers
            ////array of top 10 vacation spots
            ////print array of the first and last vacation spots
            ////array of the ages of 3 childrenr you know
            ////array of GPA's on a 4.0 scale of 8 students - you dont have to print
            ////array of first letter of 4 of your classmates names who are sitting near you
            //// print all four on same line

            //string[] vacationSpots = { "Sydney", "Orlando", "Puerto Rico", "Cuba", "California", "Canada", "DC", "Italy", "Tokyo", "Mexico" };
            //Console.WriteLine(vacationSpots[0]);
            //Console.WriteLine(vacationSpots[9]); 
            //int[] kidsAge = { 1, 5, 7, };
            //Console.WriteLine(kidsAge[0]);
            //Console.WriteLine(kidsAge[1]);
            //Console.WriteLine(kidsAge[2]);
            //double[] gpas = { 3.2, 3.0, 1.2, 1.2, 3.2, 4.0, 4.0, 2.1 };
            //char[] letter = { 'J', 'B', 'F', 'M' };
            //for (int i = 0; i < letter.Length; i++)
            //    Console.Write(letter[i] + ", ");

            ////dataType[] nameOfArray = new dataType[#ofElements];
            //int[] numberOfSeats = new int[21];
            //string[] studentsInClass = new string[21];
            ////nameOfArray[index] = element;
            //studentsInClass[0] = "Jay";

            //Console.WriteLine("Please enter in the name of next student.");
            //studentsInClass[1] = Console.ReadLine();
            //Console.WriteLine("The student in the second seat is {0}.", studentsInClass[1]);
            ////ask user for input
            //Console.WriteLine("Please enter the age of the person in the first seat.");
            ////create new int array with 21 spots 
            //int[] ageOfStudents = new int[21];
            ////assign value of the int at the 0 index of ageOfStudents to...
            //ageOfStudents[0] = int.Parse(Console.ReadLine());
            //Console.WriteLine("The age of the student in the first seat is " + ageOfStudents[0]);
            ////create new string variable and set it equal to the int at the index of 0...
            ////convert into string
            //string firstIndex = ageOfStudents[0].ToString();

            //string[] restInMall = { "Subway", "Saki", "Dunkin Donuts", "Red Lobster", "Chick" };
            //Console.WriteLine(restInMall.Length);
            ////will give you number of indices
            ////for review
            ////to declare and not initialize
            //int[] myIntArrayAgain;
            ////declare an array when i know elements
            //char[] lettersInFirstName = { 'J', 'A', 'Y' };
            ////declare and initialize an array when i dont know elements but i know how many
            //string[] variableName = new string[42];

            //practice using .Length, create a char array of the letters in your middle name

            //char[] lettersInMiddleName = { 'P', 'A', 'T', 'R', 'I', 'C', 'K' };
            //Console.WriteLine(lettersInMiddleName.Length);

            //declare and initialize string array using the .Length property, print second to last element in array
            //string[] myPhoneNumber = { "Nine", "Eight", "Six", "One", "Six", "Eight", "Seven" };
            //Console.WriteLine(myPhoneNumber[myPhoneNumber.Length - 2]);

            //IndexOf is a method used to search an array for a specified value and returns the index position of the first matching value found.
            //int[] bestYearsEver = { 1985, 1999, 1991, 2000, 1985 };
            //Console.WriteLine(Array.IndexOf(bestYearsEver, 1985));
            ////LastIndexOf is a method used to search an array for a specified value and returns the index position of the last value found
            //Console.WriteLine(Array.LastIndexOf(bestYearsEver, 1985));

            //Reverse Method
            //int[] palindromeNumbers = { 1, 2, 3, 4, 5, 6, 7 };
            //Console.WriteLine(palindromeNumbers[0]);
            //Console.WriteLine(palindromeNumbers[2]);
            //Array.Reverse(palindromeNumbers);
            //Console.WriteLine(palindromeNumbers[0]);
            //Console.WriteLine(palindromeNumbers[2]);

            //sort
            //Will sort numbers in an array from lowest to highest
            //will sort chars and strings in alphabetical order from A-Z
            //string[] powerRangers = { "Green", "Yellow", "Pink", "blue", "Red", "Black" };
            //Console.WriteLine(powerRangers[0]);
            //Array.Sort(powerRangers);
            //Console.WriteLine(powerRangers[0]);

            //string[] firstNames = { "John", "Joe", "Jay", "James" };
            //Console.WriteLine(Array.LastIndexOf(firstNames, "Jay"));

            //int[] luckyNumbers = { 1,2,3,4,1,2,3,4 };
            //Console.WriteLine(Array.LastIndexOf(luckyNumbers, 2));

            //char[] alph = { 'A', 'B', 'C', 'D', 'E' };
            //Console.WriteLine(alph[0]);
            // Array.Reverse(alph);
            //Console.WriteLine(alph[4]);

            //string[] studentsNames = { "Shawn", "Iris", "Frank", "John", "becky" };
            //Array.Sort(studentsNames);
            //Console.WriteLine(studentsNames[0]);
            //Console.WriteLine(studentsNames[4]);

            //int[] favNumber = { 8, 6, 44, 5, 6, 7, 2, 4, 9, 1 };
            //Array.Sort(favNumber);
            //Console.WriteLine(favNumber[0]);
            //Console.WriteLine(favNumber[9]);

            

            
            


        



        }
    }
}
