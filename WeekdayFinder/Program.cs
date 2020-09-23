using System;
using WeekdayFinder.Models;
namespace WeekdayFinder
{
    public class main
    {
        public static void Main()
        {
          Console.WriteLine("Enter a Month");
          String month = Console.ReadLine();
          Console.WriteLine("Enter a Day");
          String day = Console.ReadLine();
          Console.WriteLine("Enter a Year");
          String year = Console.ReadLine();
          Console.WriteLine("it is " + Day.FindDay(month,day,year));
        }
    }
}