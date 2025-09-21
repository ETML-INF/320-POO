using Drones.Helpers;
using Drones.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public partial class Building
    {
        protected Pen _pen;
        public virtual void Render(BufferedGraphics drawingSpace)
        {
            drawingSpace.Graphics.DrawRectangle(_pen,Location.X,Location.Y,_width,_height);
        }
    }
}
