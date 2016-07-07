using Nancy;
using System.Collections.Generic;
using System;
using Scrabble.Objects;
using Weekday.Objects;

namespace Scrabble
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      string[] ModelArray = {"",""};
      Get["/"] =_=> {
        return View["index.cshtml","Please Enter"];
      };
      Post["/Scrabble/created"] =_=>{
        ScrabbleGame newGame = new ScrabbleGame(Request.Form["word"]);
        ModelArray[0] = newGame.Score().ToString();
        return View["index.cshtml", ModelArray];
      };
      Post["/weekday/created"] =_=> {
        string phrase = Request.Form["date"];
        WeekdayFinder newDay = new WeekdayFinder();
        ModelArray[1] = newDay.Find(phrase);
        return View ["index.cshtml", ModelArray];

      };

    }
  }
}
