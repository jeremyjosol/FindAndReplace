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

    public static bool WordReplacer(string userInput, string findWord)
    {
      string[] sentenceArray = userInput.Split(" ");
      for (int i = 0; i < sentenceArray.Length; i++)
      {
        if (sentenceArray[i] == findWord)
        {
          return true;
        } 
      }
      return false;
    }

    public static string WordReplacer(string userInput, string findWord, string replacedWith) // overload example
    {
      string[] sentenceArray = userInput.Split(" ");
      for (int i = 0; i < sentenceArray.Length; i++)
      {
        if (sentenceArray[i].Contains(findWord))
        {
          sentenceArray[i] = sentenceArray[i].Replace(findWord, replacedWith);
        }
      }
      return string.Join(" ", sentenceArray);
    }
  }
}

