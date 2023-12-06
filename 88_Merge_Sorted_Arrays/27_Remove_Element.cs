using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas
{
    public class _27_Remove_Element
    {
        public int RemoveElement(int[] nums, int val)
        {
            int searchUntil = nums.Length;
            int removedCount = 0;
            for (int i = 0; i < searchUntil; i++)
            {
                if (nums[i] == val)
                {
                    var j = i;
                    while (j + 1 < searchUntil)
                    {
                        nums[j] = nums[j + 1];
                        j++;
                    }
                    nums[searchUntil - 1] = -1;
                    searchUntil--;
                    removedCount++;
                    i--;
                }
                else
                {
                    continue;

                }
            }

            return nums.Length - removedCount;
        }
    }
}
