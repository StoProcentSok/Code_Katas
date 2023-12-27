using System;
using System.Collections;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas
{
    public class _149_Max_Points_On_A_Line
    {
        public int MaxPoints(int[][] points)
        {
            var fPoints = points.Select(p => new PointF(p[0], p[1]));
            var pointsOnSpecificLines = new Dictionary<(PointF, PointF), IEnumerable<PointF>>();

            var pointsAlreadyChecked = pointsOnSpecificLines.Keys.Select(k => k.Item1).ToList().Concat(pointsOnSpecificLines.Keys.Select(k => k.Item2)).ToList();
            pointsAlreadyChecked.AddRange(pointsOnSpecificLines.SelectMany(v =>v.Value).ToList());

            var pointsleft = fPoints.ExceptBy(pointsAlreadyChecked, k => k);

            while (pointsleft.Count() >= 2)
            {
                var endPoint1 = pointsleft.First();
                var endPoint2 = pointsleft.Skip(1).First();


            }

            return 0;
        }

        private bool IsOnLine(PointF endPoint1, PointF endPoint2, PointF checkPoint)
        {
            if(endPoint1.X == endPoint2.X)
            {
                return checkPoint.Y == endPoint1.Y;
            }

            if(endPoint1.Y == endPoint2.Y)
            {
                return checkPoint.X == endPoint1.X;
            }

            return (((double)checkPoint.Y - endPoint1.Y)) / ((double)(checkPoint.X - endPoint1.X))
                == ((double)(endPoint2.Y - endPoint1.Y)) / ((double)(endPoint2.X - endPoint1.X));
        }
    }
}
