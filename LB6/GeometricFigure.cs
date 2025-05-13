namespace LB6;

public abstract class GeometricFigure
{
    public string name { get; set; }

    public GeometricFigure(string name)
    {
        this.name = name;
    }

    public override string ToString()
    {
        return name;
    }
}