using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas
{
    public class _4_Median_Of_Two_Sorted
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            //var nums = nums1.Concat(nums2).ToArray().Order().ToArray();
            var nums = mergeArrays(nums1, nums2);
            return MedianOfSingleArray(nums);

            //if (!nums1.Any())
            //{
            //    return MedianOfSingleArray(nums2);
            //}
            //else if (!nums2.Any())
            //{
            //    return MedianOfSingleArray(nums1);

            //}
            //else if (!nums1.Any() && !nums2.Any())
            //{
            //    return 0.0;
            //}
            //else
            //{
            //    var result = (MedianOfSingleArray(nums1) + MedianOfSingleArray(nums2)) / 2.0;
            //    return result;
            //}
        }

        private double MedianOfSingleArray(int[] nums)
        {
            if (nums.Length == 0) return 0.0;
            if (nums.Length % 2 != 0)
            {
                var floor = Math.Floor((double)(nums.Length / 2));
                return nums[(int)floor];
            }
            else
            {
                var rightOfMedian = nums.Length / 2;

                return ((nums[rightOfMedian] + nums[rightOfMedian-1]) / 2.0);
            }
        }

        private int[] mergeArrays(int[] arr1, int[] arr2)
        {
            var resultingLength = arr1.Length + arr2.Length;
            var result = new int[resultingLength];
            var i = 0; 
            var j = 0;
            for (int k = 0; k < resultingLength; k++)
            {
                if (arr1[i] <= arr2[j])
                {
                    result[k] = arr1[i];
                    i++;
                }
                else
                {
                    result[k] = arr2[j];
                    j++;
                }
            }

            return result;
        }
    }
}
