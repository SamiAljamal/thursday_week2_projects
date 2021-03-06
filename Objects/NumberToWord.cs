using System.Collections.Generic;
namespace Number.Objects
{
  public class NumberToWord
  {
    Dictionary <string, int> numberWords = new Dictionary<string, int>() {{"ninety",90},{"eighty",80},{"seventy",70},{"sixty",60},{"fifty",50},{"forty",40},{"thirty",30},{"twenty",20}, {"nineteen",19}, {"eighteen",18}, {"seventeen",17}, {"sixteen",16}, {"fiften",15}, {"fourteen",14}, {"thirteen", 13}, {"twelve",12}, {"eleven",11}, {"ten",10}, {"nine",9}, {"eight", 8}, {"seven",7}, {"six",6}, {"five",5}, {"four",4}, {"three",3}, {"two",2}, {"one",1}};

    public string Convert(int NumberToConvert)
    {
      string result = "";
      foreach(KeyValuePair<string, int> pair in numberWords)
      {
        if(NumberToConvert >= pair.Value)
        {
          result = result + pair.Key;
          NumberToConvert -= pair.Value;
        }
      }
      return result;
    }
  }
}
