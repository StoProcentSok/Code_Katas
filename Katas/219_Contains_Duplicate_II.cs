namespace Katas
{
    public class _219_Contains_Duplicate_II
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            var set = new HashSet<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (set.Contains(nums[i]))
                {
                    return true;
                }

                set.Add(nums[i]);

                if (set.Count > k)
                {
                    set.Remove(nums[i - k]);
                }
            }

            return false;
        }
    }
}
