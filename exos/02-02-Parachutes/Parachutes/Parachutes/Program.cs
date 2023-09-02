using Parachutes;

const int SCREEN_HEIGHT = 40;
const int SCREEN_WIDTH = 150;

// Initialiser la console
Console.Clear();
Console.CursorVisible = false;
Console.WindowHeight = SCREEN_HEIGHT;
Console.WindowWidth = SCREEN_WIDTH;

// Afficher l'avion
Plane plane = new Plane();
plane.draw();

while (true)
{
    Console.Clear();

    plane.update(SCREEN_WIDTH);

    plane.draw();

    Thread.Sleep(100);
}

Console.ReadKey();

