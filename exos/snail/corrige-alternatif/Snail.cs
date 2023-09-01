using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnailJMY1
{
    internal class Snail
    {

        string nickname = "bob";

        ConsoleColor color = ConsoleColor.Gray;
        int hp=50;
        int x=0;
        int y;

        string skin="_O°";

        public string Nickname { get => nickname; set => nickname = value; }
        public int Y { get => y; set => y = value; }

        public void BeReady()
        {
            Console.CursorLeft = 0;
            Console.CursorTop = y;
            Console.Write(nickname+new string(' ',skin.Length));
            x = Console.CursorLeft;
        }

        public void MoveRight()
        {
            //Position
            Console.CursorTop = y;
            Console.CursorLeft = x;

            //Couleur
            Console.ForegroundColor = color;

            //Effacer l’ancienne position
            Console.CursorLeft-=skin.Length;
            Console.Write(" ");

            //Maj hp
            hp--;
            if (hp == 0)
            {
                Console.Write("__RIP__");
            }
            else
            {
                Console.Write(skin);
            }

            x = x + 1;
            
        }
    }
}
