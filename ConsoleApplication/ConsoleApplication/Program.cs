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
        }
    }
}
