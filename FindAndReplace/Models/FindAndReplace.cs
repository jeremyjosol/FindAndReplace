using System;

namespace FindAndReplace.Models
{
  public class FindAndReplaceWord
  {
    public static string WordReplacer(string userInput)
    {
      string[] sentenceArray = userInput.Split(" ");
      return string.Join(" ", sentenceArray);
    }

    public static string WordReplacer(string userInput, string findWord, string replacedWith)
    {
      string[] sentenceArray = userInput.Split(" ");
    }
  }
}