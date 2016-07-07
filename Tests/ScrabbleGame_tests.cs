using Xunit;

namespace Scrabble.Objects
{
  public class ScrabbleGameTest
  {
    [Fact]
    public void ScrabbleGame_LetterE_1()
    {
      ScrabbleGame game = new ScrabbleGame("e");
      Assert.Equal(1, game.Score());
    }
    [Fact]
    public void ScrabbleGame_LetterD_2()
    {
      ScrabbleGame game = new ScrabbleGame("d");
      Assert.Equal(2, game.Score());
    }
    [Fact]
    public void ScrabbleGame_LetterB_3()
    {
      ScrabbleGame game = new ScrabbleGame("b");
      Assert.Equal(3, game.Score());
    }
    [Fact]
    public void ScrabbleGame_LetterF_4()
    {
      ScrabbleGame game = new ScrabbleGame("f");
      Assert.Equal(4, game.Score());
    }
    [Fact]
    public void ScrabbleGame_LetterK_5()
    {
      ScrabbleGame game = new ScrabbleGame("k");
      Assert.Equal(5, game.Score());
    }
    [Fact]
    public void ScrabbleGame_LetterJ_8()
    {
      ScrabbleGame game = new ScrabbleGame("j");
      Assert.Equal(8, game.Score());
    }
    [Fact]
    public void ScrabbleGame_LetterQ_10()
    {
      ScrabbleGame game = new ScrabbleGame("q");
      Assert.Equal(10, game.Score());
    }

  [Fact]
  public void ScrabbleGame_RealWord_12()
  {
    ScrabbleGame game = new ScrabbleGame("RealWord");
    Assert.Equal(12, game.Score());
  }
  }
}
