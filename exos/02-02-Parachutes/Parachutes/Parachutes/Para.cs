using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parachutes
{
    class Para
    {
        // View attributes
        private string[] viewNoParachute =
        {
            @"  o  ",
            @" /░\ ",
            @" / \ ",
        };
        private string[] viewWithParachute =
        {
            @" ___ ",
            @"/|||\",
            @"\   /",
            @" \o/ ",
            @"  ░  ",
            @" / \ ",
        };

        // Model attributes

        public string name;
        public int x;
        public int altitude;
        public bool parachuteIsOpen;
        public bool isInAPlane;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name"></param>
        public Para(string name)
        {
            this.name = name;
        }

        internal void update()
        {
        }

        internal void draw()
        {
            if (!this.isInAPlane)
            {
                for (int i = 0; i < viewNoParachute.Length; i++)
                {
                    Console.SetCursorPosition(x, Config.SCREEN_HEIGHT-this.altitude+i);
                    Console.Write(viewNoParachute[i]);
                }
            }
        }
    }
}
