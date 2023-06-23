using System;

namespace PalindromeExercise
{
	public class WordSmith
	{
		public WordSmith()
		{

		}
		
		public bool IsAPalindrome(string word)
		{
            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray);
            string reversed = new string(charArray);

            return word.Equals(reversed, StringComparison.OrdinalIgnoreCase);
        }
	}
}

