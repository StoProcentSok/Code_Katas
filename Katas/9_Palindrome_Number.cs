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
            if (x < 0)
            {
                return false;
            }

            var number = x.ToString().ToCharArray();

            var i = 0;
            var j = number.Length - 1;

            while (i <= j)
            {
                if (number[i] != number[j])
                {
                    return false;
                }
                i++;
                j--;
            }

            return true;
        }
    }
}
