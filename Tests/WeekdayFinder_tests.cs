using Xunit;

namespace Weekday.Objects
{
  public class WeekdayFinderTest
  {
    [Fact]
    public void WeekdayFinder_20160707_Thursday()
    {
      WeekdayFinder weekday = new WeekdayFinder();
      Assert.Equal("Thursday", weekday.Find("7/7/16"));
    }
    [Fact]
    public void WeekdayFinder_20160706_Wednesday()
    {
      WeekdayFinder weekday = new WeekdayFinder();
      Assert.Equal("Wednesday", weekday.Find("7/6/16"));
    }
    //Another day in the month of July, 2016
    [Fact]
    public void WeekdayFinder_20160730_Saturday()
    {
      WeekdayFinder weekday = new WeekdayFinder();
      Assert.Equal("Saturday", weekday.Find("7/30/16"));
    }
    //August
    [Fact]
    public void WeekdayFinder_20160801_Monday()
    {
      WeekdayFinder weekday = new WeekdayFinder();
      Assert.Equal("Monday", weekday.Find("8/1/16"));
    }
    // September
    [Fact]
    public void WeekdayFinder_20160902_Friday()
    {
      WeekdayFinder weekday = new WeekdayFinder();
      Assert.Equal("Friday", weekday.Find("9/2/16"));
    }
    [Fact]
    public void WeekdayFinder_20161231_Saturday()
    {
      WeekdayFinder weekday = new WeekdayFinder();
      Assert.Equal("Saturday", weekday.Find("12/31/16"));
    }
  }
}
