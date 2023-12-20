namespace Katas
{
    public class _50_My_Pow
    {
        public double MyPow(double x, int n)
        {
            long longN = n;
            double longX = x;

            if (longN == 1)
            {
                return x;
            }
            if (longN == 0)
            {
                return 1;
            }

            if (longN < 0)
            {
                longN = Math.Abs(longN);
                longX = 1 / longX;
            }

            return Pow(longX, longN);
        }

        private double Pow(double x, long n)
        {
            if (n == 1)
            {
                return x;
            }
            var halfedPow = Pow(x, n / 2);
            return n % 2 == 0 ? halfedPow * halfedPow : halfedPow * halfedPow * x;
        }

    }
}
