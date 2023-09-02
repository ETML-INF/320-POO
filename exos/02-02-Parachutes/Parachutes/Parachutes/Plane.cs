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
        public const int WIDTH = 28;
        public const int HEIGHT = 6;

        private string[] view =
        {
            @" _                         ",
            @"| \                        ",
            @"|  \       ______          ",
            @"--- \_____/  |_|_\____  |  ",
            @"  \_______ --------- __>-} ",
            @"        \_____|_____/   |  "
        };

        public int x;

        /// <summary>
        /// Constructor
        /// </summary>
        public Plane()
        {
            x = 0;
        }

        /// <summary>
        /// Render
        /// </summary>
        public void draw()
        {
            Console.SetCursorPosition(x, 0);
            for (int i = 0; i < view.Length; i++)
            {
                Console.SetCursorPosition(x, i);
                Console.Write(view[i]);
            }
        }

        /// <summary>
        /// Move the plane
        /// </summary>
        /// <param name="window_width"></param>
        public void update(int window_width)
        {
            if (x >= window_width)
            {
                x = 0;
            } else
            {
                x++;
            }
        }
    }
}
