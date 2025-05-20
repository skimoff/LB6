namespace LB6;

public abstract class GeometricFigure
{
    public string Name { get; protected set; }

    public GeometricFigure(string name)
    {
        Name = name;
    }
    
    public abstract double CalculateArea();
    public abstract double CalculatePerimeter();
}