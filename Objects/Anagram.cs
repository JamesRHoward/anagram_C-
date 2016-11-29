using System;
using System.Collections.Generic;

namespace AnagramChecker.Objects
{
  public class Anagram
  {
    private string _input;
    private string _anagram;

    public Anagram(string input, string anagram)
    {
      _input = input;
      _anagram = anagram;
    }
    public string GetInput()
    {
      return _input;
    }
    public void SetInput(string input)
    {
      _input = input;
    }
    public string GetAnagram()
    {
      return _anagram;
    }
    public void SetAnagram(string anagram)
    {
      _anagram = anagram;
    }
    public bool CheckAnagram()
    {
      char[] tempInput = _input.ToCharArray();
      char[] tempAnagram = _anagram.ToCharArray();
      Array.Sort(tempInput);
      Array.Sort(tempAnagram);
      for (int i = 0; i < tempInput.Length; i++)
      {
        Console.WriteLine("test" + tempInput[i] + " " + tempAnagram[i]);
        if(tempInput[i] != tempAnagram[i])
        {
          return false;
        }
      }
      return true;
    }

  }
}
