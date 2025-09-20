using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public partial class Store : Building
    {
        private List<string> _openingHours;
        public Store(int x, int y, List<string> openingHours) : base(x, y, Color.Red)
        {
            _openingHours = openingHours;
            Console.WriteLine($"New Store opening: {String.Join(",", openingHours)}");
        }
    }
}
