namespace Katas
{
    public class _135_Candy
    {
        public int Candy(int[] ratings)
        {
            var candiesGiven = 0;
            var candiesGivenToPrevious = 0;
            for (int i = 0; i < ratings.Length; i++)
            {
                if (i == 0)
                {
                    if (ratings[i +1] > ratings[i])
                    {
                        
                    }
                }
            }

            return candiesGiven;
        }
    }
}
