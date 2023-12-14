namespace Katas
{
    public class _7_Reverse_Integer
    {
        public int Reverse(int x)
        {

            var newValue = 0;
            var dummy = x > 0 ? x : x * -1;

            
            while (dummy > 0)
            {
                var overflow = dummy % 10;
                newValue = newValue * 10 + dummy % 10;
                dummy = dummy / 10;

                if (newValue%10 != overflow)
                {
                    return 0;
                }
            }

            return x > 0 ? newValue : newValue * -1;
        }
    }
}
