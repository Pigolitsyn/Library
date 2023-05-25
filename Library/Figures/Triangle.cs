using Library.Exceptions;

namespace Library.Figures;

public class Triangle : Figure
{
    private double FirstSide { get; }
    private double SecondSide { get; }
    private double ThirdSide { get; }

    public Triangle(double firstSide, double secondSide, double thirdSide)
    {
        if (firstSide <= 0 || secondSide <= 0 || thirdSide <= 0)
        {
            throw new BadInputException("Side of triangle can't be negative");
        }
        if (firstSide + secondSide < thirdSide || secondSide + thirdSide < firstSide || firstSide + thirdSide < secondSide)
        {
            throw new GeometryException("This triangle could not exist");
        }
        else
        {
            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
        }
    }

    public override double GetSquare()
    {
        var p = (FirstSide + SecondSide + ThirdSide) / 2;
        return Math.Sqrt(p * (p - FirstSide) * (p - SecondSide) * (p - ThirdSide));
    }

    public bool IsRectangle()
    {
        var firstPow = Math.Pow(FirstSide, 2);
        var secondPow = Math.Pow(SecondSide, 2);
        var thirdPow = Math.Pow(ThirdSide, 2);

        return Math.Abs(firstPow + secondPow - thirdPow) < 0.01 || Math.Abs(firstPow + thirdPow - secondPow) < 0.01 || Math.Abs(secondPow + thirdPow - firstPow) < 0.01; // сделано для точности до сотых
    }
}