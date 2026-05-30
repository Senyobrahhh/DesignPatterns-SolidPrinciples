namespace Project.OOP_Principles.Inheritance;

public class Vehicle
{
    public string Brand { get; set; }
    
    public string Model { get; set; }
    
    public int Year { get; set; }

    public void Start()
    {
        Console.WriteLine("Vehicle started");
    }
    
    public void Stop()
    {
        Console.WriteLine("Vehicle stopped");
    }
}