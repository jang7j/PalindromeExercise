using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("wow", true)]
        [InlineData("Hannah", true)]
        [InlineData("crazy", false)]
        [InlineData("great", false)]
        public void Test1(string word, bool expected)
        {
            
            var wordsmith = new WordSmith();
            var actual = wordsmith.IsAPalindrome(word);
            Assert.Equal(expected, actual);
        }

        
    }
}
