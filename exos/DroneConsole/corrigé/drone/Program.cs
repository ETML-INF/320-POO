

Console.Clear();
Console.CursorVisible = false;

Drone drone = new Drone(ConsoleColor.Blue);

while (drone.isAlive())
{
    drone.hide();
    drone.move();
    drone.show();
    Thread.Sleep(100);
}
Console.ReadKey();

/// <summary>
/// Class representing a drone
/// </summary>
public class Drone
{
    private int _x;
    private int _y;
    private ConsoleColor _color;
    private int _energy = 50;

    private const string DRONE0 = "+-O-+";
    private const string DRONE1 = "x-O-X";
    private const string NO_DRONE = "     ";
    private const string CRASHED_DRONE = "____";

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="color"></param>
    public Drone(ConsoleColor color)
    {
        _x = 1;
        _y = 10; // default birth place for drones
        _color = color;
    }

    /// <summary>
    /// Tells if the drone is stil alive
    /// </summary>
    /// <returns></returns>
    public bool isAlive()
    {
        return _energy > 0;
    }

    /// <summary>
    /// Move the beast
    /// </summary>
    public void move()
    {
        _x++; // moving left to right only at this stage
        _energy--; // moving costs energy
    }

    /// <summary>
    /// Make the drone disappear
    /// </summary>
    public void hide()
    {
        Console.SetCursorPosition(_x, _y);
        Console.Write(NO_DRONE);
    }

    /// <summary>
    /// Show the drone according to its state
    /// </summary>
    public void show()
    {
        Console.ForegroundColor = _color;
        Console.SetCursorPosition(_x, _y);
        if (this.isAlive())
        {
            Console.Write(_x % 2 == 0 ? DRONE0 : DRONE1);
        }
        else
        {
            Console.Write(CRASHED_DRONE);
        }
    }

}