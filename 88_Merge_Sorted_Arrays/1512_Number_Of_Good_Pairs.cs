using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas
{
    public class _1512_Number_Of_Good_Pairs
    {
        public int NumIdenticalPairs(int[] nums)
        {
            var result = 0;
            var moreThanOneGrouped = nums.GroupBy(x => x).Where(g => g.Count() > 1);
            foreach (var group in moreThanOneGrouped) 
            {
                result += GetGoodPairs(group);
            }
            
            return result;
        }

        private int GetGoodPairs(IEnumerable<int> nums)
        {
            var pairs = 0;
            for (int i = 1; i < nums.Count(); i++)
            {
                pairs += nums.Count() - i;
            }
            return pairs;
        }
    }
}
