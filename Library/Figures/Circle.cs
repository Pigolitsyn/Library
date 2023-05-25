using Library.Exceptions;

namespace Library.Figures;

public class Circle : Figure
{
    private double Radius
    {
        get;
    }

    public Circle(double radius)
    {
        if (radius > 0)
        {
            Radius = radius;
        }
        else
        {
            throw new BadInputException("Radius can't be negative");
        }
    }

    public override double GetSquare() => Radius * Radius * 3.14;
}