using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public class Dispatch:IDispatchable
    {
        List<Box> _boxes = new List<Box>();

        public void DropBox(Box box)
        {
            _boxes.Add(box);
            Console.WriteLine($"Dispatch reçoit une boîte: {box}");
            box.TargetStore = AirSpace.Stores.ElementAt(GlobalHelpers.alea.Next(AirSpace.Stores.Count));
            Console.WriteLine($"Elle est attribuée à {box.TargetStore.Name}");
        }

        public Box? Pickup()
        {
            if (_boxes.Count == 0) return null;
            Box box = _boxes.First();
            _boxes.Remove(box);
            Console.WriteLine($"Dispatch donne une boîte: {box}");
            return box;
        }
    }
}
