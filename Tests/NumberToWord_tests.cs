using Xunit;

namespace Number.Objects
{
  public class NumberToWordTest
  {
    [Fact]
    public void NumberToWord_1_one()
    {
      NumberToWord number = new NumberToWord();
      Assert.Equal("one",number.Convert(1));
    }
    [Fact]
    public void NumberToWord_21_twentyone()
    {
      NumberToWord number = new NumberToWord();
      Assert.Equal("twentyone",number.Convert(21));
    }
    [Fact]
    public void NumberToWord_99_ninetynine()
    {
      NumberToWord number = new NumberToWord();
      Assert.Equal("ninetynine",number.Convert(99));
    }
  }
}
