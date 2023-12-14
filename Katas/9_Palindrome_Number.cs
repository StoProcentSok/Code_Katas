using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas
{
    public class _9_Palindrome_Number
    {
        public bool IsPalindrome(int x) 
        {
            var number = x;
            var newNumber = 0;

            while (number > 0)
            {
                newNumber = newNumber * 10 + number % 10;
                number /= 10;
            }

            return newNumber == x;
        }
    }
}
