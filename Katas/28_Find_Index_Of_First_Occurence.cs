namespace Katas
{
    public class _28_Find_Index_Of_First_Occurence
    {
        public int StrStr(string haystack, string needle)
        {
            if (needle.Length == 0)
            {
                return -1;
            }

            var haystackArray = haystack.ToCharArray();
            var needleArray = needle.ToCharArray();
            var needleIndex = 0;


            for (int i = 0; i < haystackArray.Length; i++)
            {
                if (haystackArray[i] == needleArray[needleIndex])
                {
                    needleIndex++;
                }
                else
                {
                    i = i - needleIndex;
                    needleIndex = 0;
                }

                if (needleIndex == needleArray.Length)
                {
                    return i - needleIndex + 1;
                }
            }

            return -1;
        }
    }
}
