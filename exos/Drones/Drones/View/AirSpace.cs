using Drones.Model;

namespace Drones
{
    public partial class AirSpace : Form
    {
        public static readonly int WIDTH = 1200;
        public static readonly int HEIGHT = 600;
        public static readonly int CONTACT_DISTANCE = 5;
        public static readonly int MAX_SPEED = 5;


        private List<Drone> fleet;

        BufferedGraphicsContext currentContext;
        BufferedGraphics airspace;

        public AirSpace(List<Drone> fleet)
        {
            InitializeComponent();
            // Gets a reference to the current BufferedGraphicsContext
            currentContext = BufferedGraphicsManager.Current;
            // Creates a BufferedGraphics instance associated with this form, and with
            // dimensions the same size as the drawing surface of the form.
            airspace = currentContext.Allocate(this.CreateGraphics(), this.DisplayRectangle);
            this.fleet = fleet;
        }

        private void Render()
        {
            airspace.Graphics.Clear(Color.AliceBlue);

            // draw drones
            foreach (Drone drone in fleet)
            {
                drone.Render(airspace);
            }

            airspace.Render();
        }

        private new void Update()
        {
            foreach (Drone drone in fleet)
            {
                drone.Update();
            }
        }

        private void ticker_Tick(object sender, EventArgs e)
        {
            this.Update();
            this.Render();
        }
    }
}