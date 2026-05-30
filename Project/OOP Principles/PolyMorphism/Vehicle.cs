namespace Project.OOP_Principles.PolyMorphism;

public class Vehicle
{
    public string Brand { get; set; }
    
    public string Model { get; set; }
    
    public int Year { get; set; }

    public virtual void Start()
    {
        Console.WriteLine("Vehicle started");
    }
    
    public virtual void Stop()
    {
        Console.WriteLine("Vehicle stopped");
    }
}