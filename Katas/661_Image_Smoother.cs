using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Katas
{
    public class _661_Image_Smoother
    {
        public int[][] ImageSmoother(int[][] img)
        {
            var width = img.Length;
            var height = img[0].Length;

            int[][] result = new int[width][];
            for (int i = 0; i < width; i++)
            {
                result[i] = new int[height];
            }

            for (int i = 0; i < width ; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    var cellNeighbors = this.GetCellWithNeighbors(img, i, j);
                    result[i][j] = cellNeighbors.Sum()/(cellNeighbors.Length);
                }
            }

            return result;
        }

        private int[] GetCellWithNeighbors(int[][] img, int width, int height)
        {
            var result = new List<int>();
            for (int i = -1; i <= 1 ; i++)
            {
                for(int j = -1; j <= 1; j++)
                {
                    if (IsInsideArray(img, i + width, j + height))
                    {
                        result.Add(img[i + width][j + height]);
                    }
                }
            }
            return result.ToArray();
        }

        private bool IsInsideArray(int[][] img, int x, int y)
        {
            if (x < 0 || x >= img.Length
                || y < 0 || y >= img[0].Length)
            {
                return false;                
            }
            return true;
        }
    }
}
