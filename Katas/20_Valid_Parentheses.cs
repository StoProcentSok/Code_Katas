namespace Katas
{
    public class _20_Valid_Parentheses
    {
        public bool IsValid(string s)
        {
            var opensForCloses = new Dictionary<char, char>()
            {
                { ')', '(' },
                { '}', '{' },
                { ']', '[' }
            };  


            var stack = new Stack<char>();
            foreach (char character in s.ToCharArray()) 
            {
                if (opensForCloses.Values.Contains(character))
                {
                    stack.Push(character);
                }
                if (opensForCloses.Keys.Contains(character))
                {
                    if (stack.Count == 0 || stack.Peek() != opensForCloses[character])
                    {
                       return false;
                    }
                    else
                    {
                        stack.Pop();
                    }
                }
            }

            return stack.Count == 0;
        }
    }
}
