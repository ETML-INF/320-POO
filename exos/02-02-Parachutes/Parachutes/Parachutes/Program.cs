using Parachutes;

// Initialiser la console
Console.Clear();
Console.CursorVisible = false;
Console.WindowHeight = Config.SCREEN_HEIGHT;
Console.WindowWidth = Config.SCREEN_WIDTH;

// Pour les interactions utilisateur
ConsoleKeyInfo keyPressed;

// Créer l'avion avec un parachutiste
Plane plane = new Plane();
Para bob = new Para("Bob");
plane.board(bob);
bob.isInAPlane = true;

while (true)
{
    Console.Clear();
    if (Console.KeyAvailable) // L'utilisateur a pressé une touche
    {
        keyPressed = Console.ReadKey(false);
        switch (keyPressed.Key)
        {
            case ConsoleKey.Escape:
                Environment.Exit(0);
                break;
            case ConsoleKey.Spacebar:
                plane.dropParachutist();
                break;
        }
    }

    plane.update();
    bob.update();

    plane.draw();
    bob.draw();

    Thread.Sleep(100);
}


