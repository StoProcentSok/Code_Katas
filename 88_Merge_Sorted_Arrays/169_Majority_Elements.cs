using Utils;

namespace Katas
{
    public class _169_Majority_Elements
    {
        public int MajorityElement(int[] nums)
        {
            Quick_Sort.QuickSort(nums,0, nums.Length - 1);

            var midPoint = nums.Length % 2 == 0 ? (nums.Length / 2 - 1) : nums.Length / 2; // todo use Booyer Moore algo
            return nums[midPoint];
        }
    }
}
