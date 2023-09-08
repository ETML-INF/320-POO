namespace RainDrop1
{
    internal class Wind
    {
        static Random random = new Random();
        public const int East = 90;
        public const int West = 270;

        private int force;
        public int Force { get=>force; set=>force=value; }

        int direction;
        public int Direction { 
            get=>direction; 
            set=>direction=value; 
        }

        internal void Live()
        {

            var randomDirection = random.Next(360);
            if (randomDirection <= East)
            {
                direction = East;
            }
            else if (randomDirection >= West)
            {
                direction = West;
            }

            var randomForce = random.Next(3);
            force = randomForce;
        }
    }
}