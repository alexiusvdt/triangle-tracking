namespace Words
{
  public class Palindrome
  {
    public static bool IsPalindrome(string input)
    {
      for(int i = 0; i < input.Length/2; i++){
        if(input[i] == input[input.Length - 1 - i])
        {
          continue;
        }
        else {
          return false;
        }
      }
      return true;
    } 
  }
}
