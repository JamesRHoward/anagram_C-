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
    [Fact]
    public void Anagram_ChecksForAnagram_True()
    {
      var inputWord = "word";
      var inputAnagram = "drow";
      Anagram testAnagram = new Anagram(inputWord, inputAnagram);
      Assert.Equal(true, testAnagram.CheckAnagram());
    }
    [Fact]
    public void Anagram_ChecksForAnagram_False()
    {
      var inputWord = "word";
      var inputAnagram = "dog";
      Anagram testAnagram = new Anagram(inputWord, inputAnagram);
      Assert.Equal(false, testAnagram.CheckAnagram());
    }
  }
}
