using System;
using WeekdayFinder;

namespace WeekdayFinder.Models
{
  public class Day
  {
    public static string FindDay(string month, string day, string year)
    {
      int uYear = int.Parse(year);
      int uMonth = int.Parse(month);
      int uDay = int.Parse(day);
      DateTime dt = new DateTime(uYear, uMonth, uDay); 
      
      return  dt.DayOfWeek.ToString();
    }
  }
}