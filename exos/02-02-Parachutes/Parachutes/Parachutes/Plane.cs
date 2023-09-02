using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parachutes
{
    class Plane
    {
        // dimensions of the ASCII representation of the plane
        const int PLANE_WIDTH = 28;
        const int PLANE_HEIGHT = 6;

        private string[] view =
        {
            @" _                         ",
            @"| \                        ",
            @"|  \       ______          ",
            @"--- \_____/  |_|_\____  |  ",
            @"  \_______ --------- __>-} ",
            @"        \_____|_____/   |  "
        };

        private int _x;

        public Plane()
        {
            _x = 0;
        }

        public void draw()
        {
            Console.SetCursorPosition(_x, 0);
            for (int i = 0; i < view.Length; i++)
            {
                Console.SetCursorPosition(_x, i);
                Console.Write(view[i]);
            }
        }
    }
}
