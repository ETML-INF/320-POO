using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public static class GlobalHelpers
    {
        public static Random alea = new Random();
        public static bool PointsAreClose(Point p1, Point p2)
        {
            return Math.Abs(p1.X - p2.X) < 4 && Math.Abs(p1.Y - p2.Y) < 4;
        }
    }

}
