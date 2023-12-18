using System.Collections.ObjectModel;

namespace Katas
{
    public class _242_Valid_Anagram
    {
        public bool IsAnagram(string s, string t) //todo refactor to comparing two sorted char arrays
        {
            if (s.Length != t.Length)
            {
                return false;
            }

            var tSet = new Collection<char>(t.ToCharArray().ToList());
            foreach (var _char in s.ToCharArray()) 
            {
                if (tSet.Contains(_char))
                {
                    tSet.Remove(_char);
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}
