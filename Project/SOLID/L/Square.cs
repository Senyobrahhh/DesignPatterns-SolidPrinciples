namespace Project.SOLID.L;

public class Square : Shape
{
    public double SideLength { get; set; }

    public override double Area => SideLength * SideLength;
}