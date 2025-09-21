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
        private string _name;
        public string Name { get => _name; }
        public Store(string name, int x, int y, List<string> openingHours) : base(x, y, Color.Red)
        {
            _openingHours = openingHours;
            _name = name;
            Console.WriteLine($"New Store {Name} opening: {String.Join(",", openingHours)}");
        }

    }
}
