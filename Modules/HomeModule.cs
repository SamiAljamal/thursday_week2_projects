using Nancy;
using System.Collections.Generic;
using System;
using Scrabble.Objects;

namespace Scrabble
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] =_=> {
        return View["index.cshtml","Please Enter a Word"];
      };
      Post["/Scrabble/created"] =_=>{
        ScrabbleGame newGame = new ScrabbleGame(Request.Form["word"]);
        return View["index.cshtml", newGame];
      };

    }
  }
}
