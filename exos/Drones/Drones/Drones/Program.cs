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
            for (int f = 0; f < 4; f++)
            {
                buildings.Add(new Factory(
                    AirSpace.WIDTH / 8 + f * AirSpace.WIDTH / 4 + GlobalHelpers.alea.Next(0,100)-50, 
                    AirSpace.HEIGHT / 5 + GlobalHelpers.alea.Next(0, 100) - 50, 
                    GlobalHelpers.alea.Next(2000, 10000)));
            }

            for (int f = 0; f < 4; f++)
            {
                buildings.Add(new Store(
                    AirSpace.WIDTH / 8 + f * AirSpace.WIDTH / 4 + GlobalHelpers.alea.Next(0, 100) - 50,
                    4*AirSpace.HEIGHT / 5 + GlobalHelpers.alea.Next(0, 100) - 50,
                    new List<string>() { "Lu : 8h-18h", "Ma : 8h-18h", "Me : 8h-18h", "Je : 8h-18h", "Ve : 8h-18h", "Sa-Di : Fermé" }));
            }

            // Démarrage
            Application.Run(new AirSpace(fleet, buildings));
        }
    }
}