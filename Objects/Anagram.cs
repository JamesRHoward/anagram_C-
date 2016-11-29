using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;



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
      string inputWord = _input;
      string inputAnagram = _anagram;
      for (int i = 0; i < inputAnagram.Length; i++)
      {
        string temp = inputAnagram[i].ToString();
        Console.WriteLine("checking for " + temp + " in the string " + inputWord);
        if(!inputWord.Contains(temp))
        {
          return false;
        }
        else if(inputWord.Contains(temp))
        {
          var regex = new Regex(Regex.Escape(temp));
          inputWord = regex.Replace(inputWord, "_", 1);
        }
      }
      return true;
    }
  }
}
