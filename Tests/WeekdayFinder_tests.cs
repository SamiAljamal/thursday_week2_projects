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
    [Fact]
    public void WeekdayFinder_20160101_Friday()
    {
      WeekdayFinder weekday = new WeekdayFinder();
      Assert.Equal("Friday", weekday.Find("1/1/16"));
    }
    [Fact]
    public void WeekdayFinder_20170101_Sunday()
    {
      WeekdayFinder weekday = new WeekdayFinder();
      Assert.Equal("Sunday", weekday.Find("1/1/17"));
    }
    [Fact]
    public void WeekdayFinder_08000517_Wednesday()
    {
      WeekdayFinder weekday = new WeekdayFinder();
      Assert.Equal("Wednesday", weekday.Find("5/17/800"));
    }
    [Fact]
    public void WeekdayFinder_35000718_Wednesday()
    {
      WeekdayFinder weekday = new WeekdayFinder();
      Assert.Equal("Wednesday", weekday.Find("7/18/3500"));
    }
  }
}
