namespace RainDrop1
{
    internal class RainDrop
    {
        int x;
        int y;

        string skin = "|";

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }


        internal bool Live()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(skin);

            y++;

            return y > 15;

        }
    }
}