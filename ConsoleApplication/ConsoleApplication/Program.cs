using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Name and location assignment
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            Console.Write("Where are you from? ");
            string location = Console.ReadLine();
            Console.WriteLine($"My name is {name}, I am from {location}.");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

            //Current date assignment
            DateTime date = DateTime.Now;
            //DateTime date = new DateTime(2020, 12, 27);
            int thisYear = date.Year;
            int thisMonth = date.Month;
            int today = date.Day;
            Console.WriteLine($"\nThe current date is {thisMonth}-{today}-{thisYear}");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

            // Number of days until Christmas assignment
            DateTime xmas = new DateTime(date.Year, 12, 25);

            if (date > xmas)
            {
                xmas = new DateTime(date.Year + 1, 12, 25);
            }
            double totalDaysUntilXmas = Math.Round((xmas - date).TotalDays);
            Console.WriteLine($"\nIt is only {totalDaysUntilXmas} until Christmas!");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

            // Section 2.1 from the book assignment
            double width, height, woodLength, glassArea;
            string widthString, heightString;
            Console.WriteLine("\nPlease enter the width:");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            Console.WriteLine("Please enter the height:");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " + woodLength + " feet");
            Console.WriteLine("The area of the glass is " + glassArea + " square metres");
            Console.WriteLine("Press any key to exit the program");
            Console.ReadKey();

            //Need to be done on .NET framework instead
        }
    }
}
