using System;
using System.Collections.Generic;
using System.Text;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            
            var array = word.ToLower().ToCharArray();
            bool result = false;
            for (var i = 0; i < array.Length; i++)
            {
                if (array[i] == array[^(i + 1)])
                {
                    result = true;
                }
                else
                {
                    return false;
                }

            }
            return result;
           
        }
    }
}
