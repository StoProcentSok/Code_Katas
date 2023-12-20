namespace Katas
{
    public class _1913_Maximum_Difference
    {
        public int MaxProductDifference(int[] nums)
        {
            Array.Sort(nums);
            return (nums[nums.Length - 1] * nums[nums.Length - 2]
                    - nums[0] * nums[1]);
        }
    }
}
