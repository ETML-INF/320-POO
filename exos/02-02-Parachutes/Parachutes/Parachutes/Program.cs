using Parachutes;

// Initialiser la console
Console.Clear();
Console.CursorVisible = false;
Console.WindowHeight = Config.SCREEN_HEIGHT;
Console.WindowWidth = Config.SCREEN_WIDTH;

// Pour les interactions utilisateur
ConsoleKeyInfo keyPressed;

// Créer le groupe de parachutistes
List<Para> paraClub = new List<Para>();
paraClub.Add(new Para("Bob"));
paraClub.Add(new Para("Alice"));
paraClub.Add(new Para("Max"));

// Créer l'avion et embarquer le club
Plane plane = new Plane();
foreach (Para para in paraClub)
{
    para.isInAPlane = true;
    plane.board(para);
}

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
    foreach (Para para in paraClub)
    {
        para.update();
    }

    plane.draw();
    foreach (Para para in paraClub)
    {
        para.draw();
    }
    Thread.Sleep(100);
}


