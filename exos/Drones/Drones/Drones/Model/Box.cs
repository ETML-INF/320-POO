using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public class Box
    {
        private static int _lastId = 1;

        private int _id;
        private int _weight;
        private string _color;
        public Store? TargetStore { get; set; } = null;

        public Box()
        {
            _id = _lastId++;
            _weight = GlobalHelpers.alea.Next(5, 11);
            switch (GlobalHelpers.alea.Next(1, 6))
            {
                case 1: _color = "rouge"; break;
                case 2: _color = "jaune"; break;
                case 3: _color = "bleu"; break;
                case 4: _color = "brun"; break;
                case 5: _color = "orange"; break;
                default: _color = "???"; break;
            }
        }
        public Box(int weight, string color)
        {
            _id = _lastId++;
            _weight = weight;
            _color = color;
        }

        public override string ToString()
        {
            return $"Boîte {_id}, {_weight}kg de smarties {_color}s";
        }
    }
}
