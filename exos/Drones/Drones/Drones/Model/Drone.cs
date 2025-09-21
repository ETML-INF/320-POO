namespace Drones
{
    // Cette partie de la classe Drone définit ce qu'est un drone par un modèle numérique
    public partial class Drone
    {
        public static readonly int FULLCHARGE = 2000;   // Charge maximale de la batterie
        private const int CHARGE_INCREMENT = 20;        // Nombre de kWh chargés par cycle durant la recharge
        public static readonly int STANDARD_SPEED = 4;  // Vitesse normale
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
            _target = _position;
            _speed = new Point(GlobalHelpers.alea.Next(0, 8) - 4, GlobalHelpers.alea.Next(0, 8) - 4);
            _name = name;
            _charge = GlobalHelpers.alea.Next(FULLCHARGE); // La charge initiale de la batterie est choisie aléatoirement
        }
        public string Name { get { return _name; } }


        // Cette méthode calcule le nouvel état dans lequel le drone se trouve après
        // que 'interval' millisecondes se sont écoulées
        public void Update(int interval)
        {
            if (GlobalHelpers.PointsAreClose(_position, AirSpace.ChargingStation) && _charge < FULLCHARGE)
            {
                _charge += CHARGE_INCREMENT;
                if (_charge >= FULLCHARGE)
                {
                    _charge = FULLCHARGE;

                }
                _speed.X = 0;
                _speed.Y = 0;
                return;
            }
            if (_charge-- < FULLCHARGE / 2)
            {
                _target = AirSpace.ChargingStation;
            }
            else
            {
                if (GlobalHelpers.PointsAreClose(_position, _target))
                {
                    _target = NewTarget();
                }
            }
            _speed.X = Math.Abs(_position.X - _target.X) < 4 ? 0 : (_position.X > _target.X ? -STANDARD_SPEED : STANDARD_SPEED);
            _speed.Y = Math.Abs(_position.Y - _target.Y) < 4 ? 0 : (_position.Y > _target.Y ? -STANDARD_SPEED : STANDARD_SPEED);
            _position.X += _speed.X;
            _position.Y += _speed.Y;
            _charge--;                                  // Il a dépensé de l'énergie
        }

        private Point NewTarget()
        {
            // Pick a building at random
            return AirSpace.Buildings.ElementAt(GlobalHelpers.alea.Next(0, AirSpace.Buildings.Count())).Location;
        }

    }
}
