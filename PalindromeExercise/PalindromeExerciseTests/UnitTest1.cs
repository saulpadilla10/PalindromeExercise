using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("Wow", true)]
        [InlineData("Phillip", false)]
        public void IsAPalindromeTest(string word, bool expected)
        {
            WordSmith challenger = new WordSmith();

            bool actual = challenger.IsAPalindrome(word);

            Assert.Equal(expected, actual);
        }
    }
}
