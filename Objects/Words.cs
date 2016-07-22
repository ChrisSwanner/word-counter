using System;
using System.Linq;

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

    public string RemovePunctuation()
    {
      char[] punctuation = new char[] {'?', '!', '\'', '\'', '.', ',', '(', ')', ';', ':'};
      char[] searchCharArray = this.GetStringToSearch().ToCharArray();
      for (int i = 0; i < searchCharArray.Length; i++)
      {
        if (punctuation.Contains(searchCharArray[i]))
        {
          searchCharArray[i] = ' ';
        }
      }
      string result = new string(searchCharArray);
      Console.WriteLine(result);
      return result;
    }

    public int CountRepeats()
    {
      string punctuationRemoved = this.RemovePunctuation();
      string idWord = this.GetWordToIdentify().ToLower();
      string[] searchWords = punctuationRemoved.ToLower().Split(' ');
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
