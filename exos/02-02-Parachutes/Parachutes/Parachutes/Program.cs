using Parachutes;

const int SCREEN_HEIGHT = 40;
const int SCREEN_WIDTH = 150;

// Initialiser la console
Console.Clear();
Console.CursorVisible = false;
Console.WindowHeight = SCREEN_HEIGHT;
Console.WindowWidth = SCREEN_WIDTH;

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
        if (keyPressed.Key == ConsoleKey.Escape) break; // Game Over
    }

    plane.update(SCREEN_WIDTH);

    plane.draw();

    Thread.Sleep(100);
}


