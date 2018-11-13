using System;
using System.Collections.Generic;

namespace Palindrome
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter a string: ");
      string word = Console.ReadLine();


      Palindrome palindrome = new Palindrome(word);
      Console.WriteLine(palindrome.Result());
    }
  }
}
