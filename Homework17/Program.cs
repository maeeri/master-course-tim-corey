public static class Program
{
    public static void Main(string[] args)
    {
        IRun person = new Person();
        IRun animal = new Animal();

        person.Run();
        animal.Run();
    }
}


public interface IRun
{
    void Run();
}


public class Person : IRun
{
    public void Run()
    {
        throw new NotImplementedException();
    }
}

public class Animal : IRun
{
    public void Run()
    {
        Console.WriteLine("Animal is running");
    }
}