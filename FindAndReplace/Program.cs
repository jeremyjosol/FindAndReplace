using System;
using FindAndReplace.Models;

namespace FindAndReplace
{
  class Program
  {
    static void Main()
    {

      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");      
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");      
      Console.WriteLine(@"   ____  __  _    __  ____      _    __    ____    _____   ____     __     ____       _____   _____ ");
      Console.WriteLine(@"  / __/ / / / \  / / / -- \    / \  / /   /    \  /  __/  /  -  \  / /    / /\ \     / ___/  /  __/ ");
      Console.WriteLine(@" / __/ / / / / \/ / / /_/ /   / / \/ /   / /_/ / /  ---  /  /---` / /__  / /__\ \   / /__   /  --- ");
      Console.WriteLine(@"/_/   /_/ /_/  \_/ /_____/   /_/  \_/   /_/ \_\ /____/  /__/     /____/ /_/    \_\ /____/  /____/ ");
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");          
      Console.WriteLine("                                         ");
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("Welcome to the FindAndReplace application.");
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("To get started, you will enter 3 inputs.");
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("1. A sentence of your choice:~*~*~*~*~*~*");
      Console.WriteLine("2. A word you want replaced:*~*~*~*~*~*~*");
      Console.WriteLine("3. A word to replace it with:~*~*~*~*~*~*");
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("                  ");
      Console.WriteLine("Let's get started!");
      Console.WriteLine(" ");
      Console.WriteLine("Enter a sentence:");
      string userInput = Console.ReadLine();
      Console.WriteLine(" ");
      Console.WriteLine("Enter a word in the sentence you want to replace:");
      string findWord = Console.ReadLine();
      Console.WriteLine(" ");
      Console.WriteLine("Enter a word you want to replace that word with:");
      string replacedWith = Console.ReadLine();
      Console.WriteLine(" ");
      Console.WriteLine(" ");
      string result = FindAndReplaceWord.WordReplacer(userInput, findWord, replacedWith);
      Console.WriteLine("Generating result...");
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine(" ");
      Console.WriteLine($"Result: {result}");
      Console.WriteLine(" ");
      Console.WriteLine("Please enter 'new' if you would like to generate a new sentence.");
      Console.WriteLine("Otherwise, enter any key to exit the application.");
      Console.WriteLine(" ");
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