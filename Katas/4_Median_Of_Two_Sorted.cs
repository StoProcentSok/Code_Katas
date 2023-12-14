namespace Katas
{
    public class _4_Median_Of_Two_Sorted
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var nums = nums1.Concat(nums2).ToArray();
            Array.Sort(nums);
            return MedianOfSingleArray(nums);
            
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
    }
}
