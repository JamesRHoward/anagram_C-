using System;
using Nancy;
using System.Collections.Generic;
using AnagramChecker.Objects;

namespace AnagramChecker
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Get["/anagram"] = _ => {
        Anagram newAnagram = new Anagram(Request.Query["word_input"], Request.Query["anagram_input"]);
        return View["index.cshtml", newAnagram];
      };
    }
  }
}
