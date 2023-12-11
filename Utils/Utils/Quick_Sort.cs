namespace Utils
{
    public static class Quick_Sort
    {
        public static void QuickSort(int[] nums, int start, int end)
        {
            if (end <= start) return;

            var pivot = partition(nums, start, end);
            QuickSort(nums, start, pivot - 1);
            QuickSort(nums, pivot + 1, end);


        }

        private static int partition(int[] nums, int start, int end)
        {
            int pivot = nums[end];

            int i = start - 1;

            for (int j = start; j <= end; j++)
            {
                if (nums[j] < pivot)
                {
                    i++;
                    int temp = nums[i];
                    nums[i] = nums[j]; 
                    nums[j] = temp;
                }
            }
            i++;
            int temp2 = nums[i];
            nums[i] = nums[end];
            nums[end] = temp2;

            return i;
        }
    }
}
