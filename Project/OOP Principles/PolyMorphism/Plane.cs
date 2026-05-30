namespace Project.OOP_Principles.PolyMorphism;

public class Plane : Vehicle
{
    public override void Start()
    {
        Console.WriteLine("Plane started");   
    }
    public override void Stop()
    {
        Console.WriteLine("Plane stopped");  
    }
}