namespace Project.SOLID.D;

public class Car
{
    private IEngine engine;
    
    public Car(IEngine engine)
    {
        this.engine = engine;
    }

    public void StartCar()
    {
        engine.Start();
        Console.WriteLine("Car started");
    }
}