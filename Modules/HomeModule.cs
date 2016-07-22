using Nancy;
using System;
using WordCounter.Objects;

namespace WordCounter
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };

      Get["/results"] = _ => {
        return View["index.cshtml"];
      };

      Post["/results"] = _ => {
        RepeatCounter newRepeatCounter = new RepeatCounter(Request.Form["user-word"], Request.Form["user-sentence"]);
        return View["results.cshtml", newRepeatCounter];
      };
    }
  }
}
