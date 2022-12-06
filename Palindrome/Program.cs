using System;
using Words;

namespace MyProgram {
  class Program {
    static void Main(){
      Console.WriteLine("Please enter something to be checked:");
      string input = Console.ReadLine();
      Console.WriteLine(Palindrome.IsPalindrome(input));
    }

  }

}
