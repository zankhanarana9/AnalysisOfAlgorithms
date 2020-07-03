using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideAndConquer
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
    public class ClosestPairs
    {
        public double ClosestPoints(List<Point> pts, int size)
        {
            pts.Sort((lhs, rhs) => lhs.X.CompareTo(rhs.X));
            return ClosestUtil(pts, size);
            //MergeSort.Sort(P)
        }

        private double ClosestUtil(List<Point> pts, int size)
        {
            if(size <= 3)
            {
                return BruteForce(pts, size);
            }
            int mid = size / 2;
            Point midPoint = pts[mid];

            double dl = ClosestUtil(pts, mid-1);
            double dr = ClosestUtil(pts.GetRange(mid,pts.Count() - mid), size - mid);
            double d = Math.Min(dl, dr);

            List<Point> strip = new List<Point>(size);
            int j = 0;
            for(int i =0;i < size; i++)
            {
                if(Math.Abs(pts[i].X - midPoint.X) < d)
                {
                    strip.Add(pts[i]);
                    j++;
                }
            }

            return Math.Min(d, ClosestSplitPair(strip, j, d));
        }

        private double BruteForce(List<Point> pts, int size)
        {
            double min = Double.MaxValue;
            for(int i =0; i < size; i++)
            {
                for(int j = i+1; j < size; j++)
                {
                    double dist = distance(pts[i], pts[j]);
                    if(dist < min)
                    {
                        min = dist;
                    }
                }
            }
            return min;
        }

        private double ClosestSplitPair(List<Point> strip, int size, double d)
        {
            double min = d;
            strip.Sort((lhs, rhs) => lhs.Y.CompareTo(rhs.Y));
            for(int i =0; i < size; i++)
            {
                for(int j = i+1; j < size && (strip[j].Y - strip[i].Y) < min; j++)
                {
                    double dist = distance(strip[i], strip[j]);
                    if (dist < min)
                    {
                        min = dist;
                    }
                }
            }
            return min;
        }

        private double distance(Point p1, Point p2)
        {
            double d = Math.Sqrt((p2.X - p1.X) * (p2.X - p1.X) + (p2.Y - p1.Y) * (p2.Y - p1.Y));
            return d;
        }
    }
}
