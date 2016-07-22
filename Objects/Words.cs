using System;

namespace WordCounter.Objects
{
  public class RepeatCounter
  {
    private string _wordToIdentify;
    private string _stringToSearch;

    public RepeatCounter(string wordToIdentify, string stringToSearch)
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

    public int CountRepeats()
    {
      string idWord = this.GetWordToIdentify().ToLower();
      string[] searchWords = this.GetStringToSearch().ToLower().Split(' ');

      int repeatCounter = 0;

      foreach (string word in searchWords)
      {
        if (idWord == word)
        {
          repeatCounter++;
        }
      }
      return repeatCounter;
    }
  }
}
