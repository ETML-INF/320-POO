using Drones.Helpers;

namespace Drones.Model
{
    public class Drone
    {
        public static readonly int FULLCHARGE = 1000;
        private string _name;
        private int _x;
        private int _y;
        private int _charge;
        private Pen droneBrush = new Pen(new SolidBrush(Color.Purple), 3);

        public Drone(int x, int y, string name)
        {
            _x = x;
            _y = y;
            _name = name;
            _charge = GlobalHelpers.alea.Next(FULLCHARGE);
        }
        public int X { get { return _x;} }
        public int Y { get { return _y;} }
        public string Name { get { return _name;} }

        public void Update()
        {
            _x += GlobalHelpers.alea.Next(-1, 2);
            _y += GlobalHelpers.alea.Next(-1, 2);
            _charge--;
        }

        public void Render(BufferedGraphics drawingSpace) {
            drawingSpace.Graphics.DrawEllipse(droneBrush, new Rectangle(X - 4, Y - 2, 8, 8));
            drawingSpace.Graphics.DrawString($"{this}", TextHelpers.drawFont, TextHelpers.writingBrush, X + 5, Y - 5);
        }
        public override string ToString()
        {
            return $"{Name} ({((int)((double)_charge/FULLCHARGE*100)).ToString()}%)";
        }

    }
}
