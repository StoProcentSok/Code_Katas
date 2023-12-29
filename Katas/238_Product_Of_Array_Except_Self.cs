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

            var i = 0;
            while (i < nums.Length)
            {
                for (var j = i - 1; j > -1; j--)
                {
                    result[i] = result[i] * nums[j];
                }

                for (var j = i + 1; j < nums.Length; j++)
                {
                    result[i] = result[i] * nums[j];
                }

                i++;
            }
            return result;
        }
    }
}
