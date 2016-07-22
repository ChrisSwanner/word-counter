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
      char idWord = System.Convert.ToChar(this.GetWordToIdentify());
      char[] searchWords = this.GetStringToSearch().ToCharArray();
      foreach (char letter in searchWords)
      {
        if (idWord == letter)
        {
          return 1;
        }
        else
        {
          return 0;
        }
      }
      return 0;
    }
  }
}
