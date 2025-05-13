namespace LB6;

public class Oval : GeometricFigure
{
    public double MajorAxis { get; set; }
    public double MinorAxis { get; set; }

    public Oval(string name, double major, double minor) : base(name)
    {
        if (major <= 0 || minor <= 0)
            throw new ArgumentException("Axes must be positive.");

        MajorAxis = major;
        MinorAxis = minor;
    }
}