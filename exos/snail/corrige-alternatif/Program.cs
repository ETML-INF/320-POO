using SnailJMY1;

var snail1 = new Snail();
snail1.Nickname = "steph";
snail1.Y = 1;

var snail2 = new Snail();
snail2.Nickname = "bob";
snail2.Y = 2;

snail1.BeReady();
snail2.BeReady();

for (int i = 0; i < 20; i++)
{
    snail1.MoveRight();
    snail2.MoveRight();

    Thread.Sleep(250);
}


/*
for (int i = 0; i < 10; i++)
{
    
}
Console.Write("   \n   ");
var hp1 = 50;
var hp2 = 50;
var ySnail1 = 0;
var ySnail2 = 1;

while (true)
{
    if (Console.KeyAvailable)
    {
        var key = Console.ReadKey(true);
        if (key.Key == ConsoleKey.RightArrow)
        {
            Console.CursorTop = ySnail1;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.CursorLeft -= 3;
            Console.Write("_");
            Console.Write("_o°");
            hp1--;
            if(hp1==0) 
            {
                Console.Clear();
                Console.Write("__RIP__");
                break;
            }
        }

        if (key.Key == ConsoleKey.LeftArrow)
        {
            Console.CursorTop = ySnail2;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.CursorLeft -= 3;
            Console.Write("_");
            Console.Write("_o°");
            hp2--;
            if (hp2 == 0)
            {
                Console.Clear();
                Console.Write("__RIP__");
                break;
            }
        }

        if (key.Key == ConsoleKey.RightArrow)
        {
            Console.CursorTop = ySnail1;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.CursorLeft -= 3;
            Console.Write("_");
            Console.Write("_o°");
            hp1--;
            if (hp1 == 0)
            {
                Console.Clear();
                Console.Write("__RIP__");
                break;
            }
        }
    }
    
}
*/