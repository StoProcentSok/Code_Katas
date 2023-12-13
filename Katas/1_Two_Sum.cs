using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace Katas
{
    public class _1_Two_Sum
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var searchUntil = nums.Length;
            var result = new List<int>();

            for (var i = 0; i < searchUntil; i++)
            {
                if (result.Count == 2) break;
                {
                    
                }
                for (var j = i + 1; j < searchUntil; j++)
                {
                    if ((nums[i] + nums[j] == target))
                    {
                        result.AddRange(new int[] { i, j });
                        break;
                    }
                }
            }

            return result.ToArray();
        }
    }
}
