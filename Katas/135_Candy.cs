namespace Katas
{
    public class _135_Candy
    {
        public int Candy(int[] ratings)
        {
            var candiesForKids = new int[ratings.Length];
            Array.Fill(candiesForKids, 1);
 
            for (int i = 1; i < ratings.Length; i++)
            {
                if (ratings[i-1] < ratings[i])
                {
                    candiesForKids[i] = candiesForKids[i - 1] + 1;
                }
            }

            for (int j = ratings.Length - 2; j >= 0 ; j--)
            {
                if (ratings[j] > ratings[j + 1])
                {
                    candiesForKids[j] = (candiesForKids[j+1] + 1 > candiesForKids[j]) 
                        ? candiesForKids[j + 1] + 1 
                        : candiesForKids[j];
                }
            }

            return candiesForKids.Sum();
            
        }
    }
}
