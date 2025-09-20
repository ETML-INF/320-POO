using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public class Factory : Building
    {
        private static int _lastId = 1;
        
        private static int _id;

        private double _powerConsumption;
        public double PowerConsumption { get => _powerConsumption;}
        public Factory(int x, int y, double powerConsumption) : base(x, y, Color.Blue)
        {
            _id = _lastId++;
            _powerConsumption = powerConsumption;
            Console.WriteLine($"New Fatory consuming: {PowerConsumption} kWh");
        }

    }
}
