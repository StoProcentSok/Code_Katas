namespace Katas
{
    public class _1637_Widest_Area_Without_Point
    {
        public int MaxWidthOfVerticalArea(int[][] points)
        {
            var sortedPoints = points.OrderBy(p => p.First()).ToArray();
            var widest = 0;

            for (int i = 0; i < sortedPoints.Length - 1; i++)
            {
                widest = Math.Max(sortedPoints[i+1].First() - sortedPoints[i].First(), widest);
            }

            return widest;
        }
    }
}
