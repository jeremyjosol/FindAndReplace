using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindAndReplace.Models;


namespace FindAndReplace.Tests
{
  [TestClass]
  public class FindAndReplaceTests
  {
    [TestMethod]
    public void WordReplacer_SplitsUserInputIntoArray_String()
    {
      string userInput = "Hello sir"; // example input, imitates UI logic
      string result = FindAndReplaceWord.WordReplacer(userInput);
      Assert.AreEqual("Hello sir", result);
    }
    [TestMethod]
    public void WordReplacer_FindCorrectWord_Bool()
    {
      string userInput = "Hello sir";
      string findWord = "sir";
      bool result = FindAndReplaceWord.WordReplacer(userInput, findWord);
      Assert.IsTrue(result);
    }

    [TestMethod]
    public void WordReplacer_FindWordAndReplaceWith_String()
    {
      string userInput = "Hello sir";
      string findWord = "sir";
      string replacedWith = "maam";
      string result = FindAndReplaceWord.WordReplacer(userInput, findWord, replacedWith);
      Assert.AreEqual("Hello maam", result);
    }

    [TestMethod]
    public void WordReplacer_FindAllWordOccurencesAndReplaceWith_String()
    {
      string userInput = "Hello sir how are yousir";
      string findWord = "sir";
      string replacedWith = "maam";
      string result = FindAndReplaceWord.WordReplacer(userInput, findWord, replacedWith);
      Assert.AreEqual("Hello maam how are youmaam", result);
    }

    [TestMethod]
    public void WordReplacer_FindAllWordOccurencesAndReplaceWith2_String()
    {
      string userInput = "Hesirllo sir how are yousir";
      string findWord = "sir";
      string replacedWith = "maam";
      string result = FindAndReplaceWord.WordReplacer(userInput, findWord, replacedWith);
      Assert.AreEqual("Hemaamllo maam how are youmaam", result);
    }
  }
}