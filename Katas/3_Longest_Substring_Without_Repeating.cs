namespace Katas
{
    public class _3_Longest_Substring_Without_Repeating
    {
        public int LengthOfLongestSubstring(string s)
        {
            if (s.Length == 0) return 0;
            var indexA = 0;
            var indexB = 0;
            var max = 0;

            var sArray = s.ToCharArray();
            var set = new HashSet<char>();


            while (indexB < s.Length) 
            {
                if (!set.Contains(sArray[indexB]))
                {
                    set.Add(sArray[indexB]);
                    indexB++;
                    max = Math.Max(max, (indexB - indexA));
                }
                else
                {
                    set.Remove(sArray[indexA]);
                    indexA++;
                }
            }

            return max;
        }
    }
}
