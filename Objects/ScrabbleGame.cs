using Xunit;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace Scrabble.Objects
{
  public class ScrabbleGame
  {
    private string _word;

    public ScrabbleGame(string word)
    {
      _word = word;
    }

    public int Score()
    {
      int FinalScore = 0;

      Dictionary<string, int> LetterScores = new Dictionary<string, int>()
      { {"aeioulnrst", 1}, {"dg", 2}, {"bcmp", 3}, {"fhvwy", 4}, {"k",5}, {"jx",8},{"qz",10} };
      foreach (KeyValuePair<string, int> pair in LetterScores)
      {
        string selector = "(?i)[" + pair.Key + "]";
        FinalScore += Regex.Matches(_word, selector).Count * pair.Value;
      }

      return FinalScore;
    }
  }
}
