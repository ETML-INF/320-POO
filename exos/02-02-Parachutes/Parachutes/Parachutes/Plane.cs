using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parachutes
{
    class Plane
    {
        // Display attributes
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

        // Model attributes
        public int x;
        public int altitude;
        public List<Para> parachutists;

        /// <summary>
        /// Constructor
        /// </summary>
        public Plane()
        {
            x = 0;
            altitude = Config.SCREEN_HEIGHT;
            parachutists = new List<Para>();
        }

        /// <summary>
        /// Render
        /// </summary>
        public void draw()
        {
            for (int i = 0; i < view.Length; i++)
            {
                Console.SetCursorPosition(x, i);
                Console.Write(view[i]);
            }
        }

        /// <summary>
        /// Move the plane
        /// </summary>
        public void update()
        {
            if (x >= Config.SCREEN_WIDTH)
            {
                x = 0;
            }
            else
            {
                x++;
            }
        }

        /// <summary>
        /// Take a parachustist on board
        /// </summary>
        /// <param name="para"></param>
        public void board(Para para)
        {
            this.parachutists.Add(para);
        }

        internal Para dropParachutist()
        {
            Para parachutist = parachutists.First();
            parachutists.Remove(parachutist);
            parachutist.x = x;
            parachutist.altitude = this.altitude;
            return parachutist;
        }
    }
}
