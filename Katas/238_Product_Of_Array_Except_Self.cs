using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas
{
    public class _238_Product_Of_Array_Except_Self
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            var result = new int[nums.Length];
            Array.Fill(result, 1);

            var prefix = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = prefix;
                prefix *= nums[i];
            }

            var postfix = 1;
            for (int i = nums.Length - 1; i > -1; i--)
            {
                result[i] = result[i] * postfix;
                postfix *= nums[i];
            }
            return result;
        }
    }
}
