using System;
using System.Collections.Generic;

namespace WordCounter.Objects
{
  public class Words
  {
    private string _wordToIdentify;
    private string _stringToSearch;

    public Words(string wordToIdentify, string stringToSearch)
    {
      _wordToIdentify = wordToIdentify;
      _stringToSearch = stringToSearch;
    }

    public string GetWordToIdentify()
    {
      return _wordToIdentify;
    }
    public void SetWordToIdentify(string newWordToIdentify)
    {
      _wordToIdentify = newWordToIdentify;
    }

    public string GetStringToSearch()
    {
      return _stringToSearch;
    }
    public void SetStringToSearch(string newStringToSearch)
    {
      _stringToSearch = newStringToSearch;
    }

    public int Compare()
    {
      //initial placeholder return value of method
      return 0;
    }
  }
}
