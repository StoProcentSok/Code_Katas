namespace Katas
{
    public class _58_Length_Of_Last_Word
    {
        public int LengthOfLastWord(string s)
        {
            var words = s.Split(' ', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
            return words.Last().Length;
        }
    }
}
