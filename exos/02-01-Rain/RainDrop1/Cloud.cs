namespace RainDrop1
{
    internal class Cloud
    {
        string skin="CLOUD";
        int x;
        int y=5;

        int direction;

        RainDrop? drop;

        public void Live(Wind wind)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(skin);

            if(wind.Direction == Wind.East)
            {
                x += wind.Force;
            }
            else if(wind.Direction == Wind.West)
            {
                x-= wind.Force;
            }
            if(x<0)
            {
                y += 1;
                x = 0;
            }
            if (x > Console.WindowWidth-skin.Length)
            {
                y += 1;
                x = 0;
            }

            //Gestion des gouttes
            if (drop == null)
            {
                drop = new RainDrop();
                drop.X= x;
                drop.Y = y + 1;
            }
            var dead = drop.Live();
            if (dead)
            {
                drop = null;
            }
        }
    }
}