using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public interface IDispatchable
    {
        // Dépose d'une boîte de smarties 
        public void DropBox(Box box);

        // Prise d'une boîte de smarties
        // Retourne `null` s'il n'y a pas de boîte en stock
        public Box? Pickup();

    }
}
