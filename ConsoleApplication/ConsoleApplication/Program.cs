using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Rizky";
            string location = "Indonesia";
            Console.WriteLine($"My name is {name}, I am from {location}.");

            //Current date
            DateTime date = DateTime.Now;
            int thisYear = date.Year;
            int thisMonth = date.Month;
            int today = date.Day;
            Console.WriteLine($"The current date is {thisMonth}-{today}-{thisYear}");

            //Number of days until Christmas
            DateTime xmas = new DateTime(date.Year, 12, 25);
            double totalDaysUntilXmas = Math.Round((xmas - date).TotalDays);
            Console.WriteLine($"It is only {totalDaysUntilXmas} until Christmas!");

            //Section 2.1 from the book
            double width, height, woodLength, glassArea;
            string widthString, heightString;
            Console.WriteLine("Please enter the width:");
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
        }
    }
}
