using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public partial class Building
    {
        protected int _x;
        protected int _y;
        protected int _width;
        protected int _height;

        public int X { get => _x; set => _x = value; }
        public int Y { get => _y; set => _y = value; }
        public int Width { get => _width; set => _width = value; }
        public int Height { get => _height; set => _height = value; }
        public Building(int x, int y, Color color)
        {
            _x = x;
            _y = y;
            _width = Config.BUILDING_SIZE;
            _height = Config.BUILDING_SIZE;
            _pen = new Pen(color);
        }

    }
}
