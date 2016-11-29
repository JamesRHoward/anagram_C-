using Xunit;
using AnagramChecker.Objects;
using System.Collections.Generic;

namespace AnagramCheckerTest
{
  public class AnagramTest
  {
    [Fact]
    public void Anagram_InputFirstWord_True()
    {
      var inputWord = "word";
      Anagram testAnagram = new Anagram(inputWord, "");
      Assert.Equal("word", testAnagram.GetInput());
    }
    [Fact]
    public void Anagram_InputAnagram_True()
    {
      var anagramWord = "drow";
      Anagram testAnagram = new Anagram("", anagramWord);
      Assert.Equal("drow", testAnagram.GetAnagram());
    }
  }
}
