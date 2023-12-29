namespace Katas
{
    public class _11_Container_With_Most_Water
    {
        public int MaxArea(int[] height)
        {
            var maxVolume = 0;
            var firstWall = 0;
            var secondWall = height.Length - 1;

            while(firstWall <= secondWall)
            {
                var containerHeight = Math.Min(height[firstWall], height[secondWall]);
                var volume = containerHeight * (secondWall - firstWall);
                maxVolume = Math.Max(maxVolume, volume);

                if (height[firstWall] <= height[secondWall])
                {
                    firstWall++;
                }
                else
                {
                    secondWall--;
                }
            }

            return maxVolume;
        }
    }
}
