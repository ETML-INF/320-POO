namespace Drones
{
    // Cette partie de la classe Drone définit ce qu'est un drone par un modèle numérique
    public partial class Drone
    {
        public static readonly int FULLCHARGE = 1000;   // Charge maximale de la batterie
        private int _charge;                            // La charge actuelle de la batterie
        private string _name;                           // Un nom
        private Point _position;
        private Point _speed;
        private Point _target;
        public Point Position { get => _position; }

        // Constructeur
        public Drone(int x, int y, string name)
        {
            _position = new Point(x, y);
            _speed = new Point(GlobalHelpers.alea.Next(0,8)-4, GlobalHelpers.alea.Next(0,8)-4);
            _name = name;
            _charge = GlobalHelpers.alea.Next(FULLCHARGE); // La charge initiale de la batterie est choisie aléatoirement
        }
        public string Name { get { return _name;} }


        // Cette méthode calcule le nouvel état dans lequel le drone se trouve après
        // que 'interval' millisecondes se sont écoulées
        public void Update(int interval)
        {
            _position.X += _speed.X;
            _position.Y += _speed.Y;
            _charge--;                                  // Il a dépensé de l'énergie
        }

    }
}
