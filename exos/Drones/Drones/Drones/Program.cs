namespace Drones
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Création de la flotte de drones
            List<Drone> fleet= new List<Drone>();
            fleet.Add(new Drone(AirSpace.WIDTH / 2, AirSpace.HEIGHT / 2, "Joe"));

            List<Building> buildings= new List<Building>();
            buildings.Add(new Building(20, 20, 50, 25, Color.Black));
            buildings.Add(new Building(120, 20, 50, 25, Color.Black));
            buildings.Add(new Building(20, 220, 50, 25, Color.Black));

            // Démarrage
            Application.Run(new AirSpace(fleet, buildings));
        }
    }
}