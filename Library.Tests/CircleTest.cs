using Library.Exceptions;
using Library.Figures;

namespace Library.Tests;

public class CircleTest
{
    [Fact]
    public void TestGetSquare()
    {
        Assert.Equal(78.5,  new Circle(radius: 5).GetSquare());
    }

    [Fact]
    public void ThrowExceptionNegativeRadius()
    {
        Assert.Throws<BadInputException>(() => new Circle(-5));
    }
}