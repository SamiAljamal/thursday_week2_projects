using System.Collections.Generic;
using System;

namespace Weekday.Objects
{
  public class WeekdayFinder
  {
    string[] weekdays = {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"};

    public bool IsLeapYear(int year)
    {
      if (year % 400 == 0)
      {
        return true;
      }
      else if (year%100==0)
      {
        return false;

      }
      else if (year % 4 == 0)
      {
          return true;
      }
      else
      {
        return false;
      }
    }

    public string Find(string dateString)
    {
      // string[] dateStringArray = dateString.Split('/');
      int monthNumber = int.Parse(dateString.Split('/')[0]);
      monthNumber -= 1;
      int dayNumber = int.Parse(dateString.Split('/')[1]);
      int yearNumber = int.Parse(dateString.Split('/')[2]);
      int[] monthLength = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
      int yearLength = 365;
      if(yearNumber < 100)
      {
        yearNumber += 2000;
      }
      Console.WriteLine(IsLeapYear(yearNumber));
      if(IsLeapYear(yearNumber) == true)
      {
        monthLength[1] = 29;
      }
      for(int i = 0; i<monthNumber; i++)
      {
        dayNumber += monthLength[i];
      }

      for(int i = 0; i<yearNumber; i++)
      {
        if(IsLeapYear(i))
        {
          yearLength += 1;
        }
        else
        {
          yearLength = 365;
        }
        dayNumber += yearLength;
      }
      Console.WriteLine("Year: " + yearNumber.ToString());
      Console.WriteLine("Month: " + monthNumber.ToString());
      Console.WriteLine("Date: " + dayNumber.ToString());
      return weekdays[(dayNumber +12)%7];
    }
  }
}
