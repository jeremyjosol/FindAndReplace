using System;
using FindAndReplace.Models;

namespace FindAndReplace
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("                                         ");
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("Welcome to our FindAndReplace application.");
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("                                         ");
      Console.WriteLine("This application will take 3 inputs from you.");
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("                                         ");
      Console.WriteLine("1. A sentence of your choice:");
      Console.WriteLine("2. A word you want replaced:");
      Console.WriteLine("3. A word to replace with:");
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("                  ");
      Console.WriteLine("Let's get started!");
      Console.WriteLine("Enter an interesting sentence:");
      string userInput = Console.ReadLine();
      Console.WriteLine("Enter a word in that sentence you want to replace:");
      string findWord = Console.ReadLine();
      Console.WriteLine("Enter a word you want to replace the previous word with:");
      string replacedWith = Console.ReadLine();
      Console.WriteLine("Generating...");
      Console.WriteLine("..............");
      Console.WriteLine("...............");
      Console.WriteLine("................");
      Console.WriteLine("                  ");
      string result = FindAndReplaceWord.WordReplacer(userInput, findWord, replacedWith);
      Console.WriteLine($"Result: {result}");
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("Please enter 'new' if you would like to generate a new sentence:");
      string userResponse = Console.ReadLine();
      if (userResponse == "new" || userResponse == "New")
      {
        Main();
      }
      else
      {
        Console.WriteLine("*~*~*~*~*~*");
        Console.WriteLine("*~*~*~*~*~*");
        Console.WriteLine("*~Goodbye~*!");
        Console.WriteLine("*~*~*~*~*~*");
        Console.WriteLine("*~*~*~*~*~*");
      }
      





    }
  }
}