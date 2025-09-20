using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public class Factory : Building
    {
        private const int PRODUCTION_INTERVAL = 5000;
        private static int _lastId = 1;
        
        private int _id;
        private int _timeCounter;

        private double _powerConsumption;
        public double PowerConsumption { get => _powerConsumption;}
        public Factory(int x, int y, double powerConsumption) : base(x, y, Color.Blue)
        {
            _id = _lastId++;
            _powerConsumption = powerConsumption;
            _timeCounter = GlobalHelpers.alea.Next(0, PRODUCTION_INTERVAL); // Just so that all factories don't produce simultaneously
            Console.WriteLine($"New Fatory consuming: {PowerConsumption} kWh");
        }

        public void Update(int interval)
        {
            _timeCounter += interval;
            if (_timeCounter > PRODUCTION_INTERVAL)
            {
                Box box = new Box();
                Console.WriteLine($"L'usine {_id} produit :{box}");
                AirSpace.Dispatcher.DropBox( box );
                _timeCounter = 0;
            }
        }
    }
}
