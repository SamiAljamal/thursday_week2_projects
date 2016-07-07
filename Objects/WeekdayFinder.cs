using System.Collections.Generic;
using System;

namespace Weekday.Objects
{
  public class WeekdayFinder
  {
    string[] weekdays = {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"};
    int[] monthLength = {31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};

    public string Find(string dateString)
    {
      // string[] dateStringArray = dateString.Split('/');
      int monthNumber = int.Parse(dateString.Split('/')[0]);
      monthNumber -= 1;
      int dayNumber = int.Parse(dateString.Split('/')[1]);
      int yearNumber = int.Parse(dateString.Split('/')[2]);
      if(monthNumber > 0)
      {
        for(int i = 0; i<monthNumber; i++)
        {
          dayNumber += monthLength[i];
        }
        // dayNumber += 31;
      }
      Console.WriteLine("Month: " + monthNumber.ToString());
      Console.WriteLine("Date: " + dayNumber.ToString());
      return weekdays[(dayNumber +11)%7];
    }
  }
}
