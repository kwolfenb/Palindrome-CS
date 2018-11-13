using System;
using System.Collections.Generic;
using System.Linq;

namespace Palindrome
{

  class Palindrome
  {
    private string Word;


    public Palindrome(string word) // Constructor method for Palindrome Class
    {
      Word=word;
    }
    public bool Result()
    {
      char[] word1 = Word.ToCharArray();
      char[] reverseArray = new char[Word.Length] ;
      for(int i=Word.Length; i>0; i--){
        reverseArray[Word.Length-i] = word1[i-1];

      }
      return (Word == string.Join("", reverseArray));

    }
  }
}
