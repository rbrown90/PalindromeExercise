using Xunit;
using PalindromeExercise;
using System;

namespace Palindrome.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData ("noon", true)]
        [InlineData("Hey", false)]
        public void PalindromeExervise(string word, bool expected)
        {
            var test = new WordSmith();

            var actual = test.IsAPalindrome(word);

            Assert.Equal(expected, actual);
        }
    }
}
