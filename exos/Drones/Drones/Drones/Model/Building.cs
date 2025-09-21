using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public partial class Building
    {
        private Point location;
        protected int _width;
        protected int _height;

        public Point Location { get => location; set => location = value; }
        public int Width { get => _width; set => _width = value; }
        public int Height { get => _height; set => _height = value; }

        public Building(int x, int y, Color color)
        {
            location = new Point(x, y);
            _width = Config.BUILDING_SIZE;
            _height = Config.BUILDING_SIZE;
            _pen = new Pen(color);
        }

    }
}
