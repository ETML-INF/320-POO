namespace Drones
{
    // La classe AirSpace représente le territoire au dessus duquel les drones peuvent voler
    // Il s'agit d'un formulaire (une fenêtre) qui montre une vue 2D depuis en dessus
    // Il n'y a donc pas de notion d'altitude qui intervient

    public partial class AirSpace : Form
    {
        public static readonly int WIDTH = 1200;        // Dimensions of the airspace
        public static readonly int HEIGHT = 600;

        // La flotte est l'ensemble des drones qui évoluent dans notre espace aérien
        private List<Drone> _fleet;
        private List<Building> _buildings;

        BufferedGraphicsContext currentContext;
        BufferedGraphics airspace;

        public static Dispatch Dispatcher = new Dispatch();
        public static List<Store> Stores;

        public static Point ChargingStation = new Point(30, AirSpace.HEIGHT/2);

        // Initialisation de l'espace aérien avec un certain nombre de drones
        public AirSpace(List<Drone> fleet, List<Building> buildings)
        {
            InitializeComponent();
            // Gets a reference to the current BufferedGraphicsContext
            currentContext = BufferedGraphicsManager.Current;
            // Creates a BufferedGraphics instance associated with this form, and with
            // dimensions the same size as the drawing surface of the form.
            airspace = currentContext.Allocate(this.CreateGraphics(), this.DisplayRectangle);
            this._fleet = fleet;
            this._buildings = buildings;
            Stores = buildings.Where(b => b.GetType() == typeof(Store)).Select(b => (Store)b).ToList();
        }

        // Affichage de la situation actuelle
        private void Render()
        {
            airspace.Graphics.Clear(Color.AliceBlue);

            // draw drones
            foreach (Drone drone in _fleet)
            {
                drone.Render(airspace);
            }

            // draw buildings
            foreach (Building building in _buildings)
            {
                building.Render(airspace);
            }

            // Draw charging station
            airspace.Graphics.DrawEllipse(new Pen(Color.Orange,5), AirSpace.ChargingStation.X, AirSpace.ChargingStation.Y, 5, 5);

            airspace.Render();
        }

        // Calcul du nouvel état après que 'interval' millisecondes se sont écoulées
        private void Update(int interval)
        {
            foreach (Drone drone in _fleet)
            {
                drone.Update(interval);
            }
            
            // Activate factories
            foreach (Building building in _buildings)
            {
                if (building.GetType() == typeof(Factory))
                {
                    ((Factory)building).Update(interval);
                }
            }
        }

        // Méthode appelée à chaque frame
        private void NewFrame(object sender, EventArgs e)
        {
            this.Update(ticker.Interval);
            this.Render();
        }
    }
}