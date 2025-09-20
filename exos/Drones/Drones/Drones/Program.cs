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
            buildings.Add(new Factory(20, 20, 2500.0));
            buildings.Add(new Factory(120, 20,  4000));
            buildings.Add(new Store(20, 220, new List<string>() { "Lu : 8h-18h", "Ma : 8h-18h", "Me : 8h-18h", "Je : 8h-18h", "Ve : 8h-18h", "Sa-Di : Fermé" }));

            // Démarrage
            Application.Run(new AirSpace(fleet, buildings));
        }
    }
}