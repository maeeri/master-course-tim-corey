GameController gameController = new GameController();
gameController.Connect();
gameController.CurrentKeyPressed();
gameController.SomeOtherMethod();
Console.ReadLine();

public interface IShape
{
    double Area { get; }
    double Perimeter { get; }
}

public class Circle : IShape
{
    public double Radius { get; set; }

    public double Area => Math.PI * Math.Pow(Radius, 2);

    public double Perimeter => 2 * Math.PI * Radius;
}

public class Rectangle : IShape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public double Area => Width * Height;

    public double Perimeter => 2 * (Width + Height);
}

public class Keyboard : IInputDevice
{
    public void Connect()
    {
        Console.WriteLine("Keyboard connected");
    }

    public void CurrentKeyPressed()
    {
        Console.WriteLine("Key pressed");
    }


}

public class  GameController : IInputDevice
{
    public void Connect()
    {
        Console.WriteLine("Game controller connected");
    }

    public void CurrentKeyPressed()
    {
        Console.WriteLine("Button pressed");
    }
    
    public void SomeOtherMethod()
    {
        Console.WriteLine("Some other method");
    }
}

interface IInputDevice
{
    void Connect();
    void CurrentKeyPressed();
}