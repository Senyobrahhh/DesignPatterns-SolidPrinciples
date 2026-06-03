namespace Project.OOP_Principles.Composition;

public class Truck
{
    private Engine engine = new Engine();
    private Wheels wheels = new Wheels();
    private Chassis chassis = new Chassis();
    private Seats seats = new Seats();
    
    public void Start()
    {
        engine.Start();
        wheels.Rotate();
        chassis.Support();
        seats.Sit();
    }
}