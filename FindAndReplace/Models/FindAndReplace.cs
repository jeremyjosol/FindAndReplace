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

    public static string WordReplacer(string userInput, string findWord)
    {
      string isTrue = " ";
      string[] sentenceArray = userInput.Split(" ");
      for (int i = 0; i < sentenceArray.Length; i++)
      {
        if (sentenceArray[i] == findWord)
        {
          isTrue = "true";
        
        } 
        else 
        {
          isTrue = "false";
        }
      }
      return isTrue;
    }
  }
}


