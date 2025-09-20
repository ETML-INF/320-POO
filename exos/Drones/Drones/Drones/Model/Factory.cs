using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public class Factory : Building
    {
        private double _powerConsumption;
        public double PowerConsumption { get => _powerConsumption;}
        public Factory(int x, int y, double powerConsumption) : base(x, y, Color.Blue)
        {
            _powerConsumption = powerConsumption;
            Console.WriteLine($"New Fatory consuming: {PowerConsumption} kWh");
        }

    }
}
