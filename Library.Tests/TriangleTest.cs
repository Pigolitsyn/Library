using Library.Exceptions;
using Library.Figures;

namespace Library.Tests;

public class TriangleTest
{
    [Fact]
    public void TestGetSquare()
    {
        Assert.Equal(12,  new Triangle(5, 5, 6).GetSquare());
    }

    [Fact]
    public void TestBadInput1()
    {
        Assert.Throws<BadInputException>(() => new Triangle(-5, 5, 6));
    }

    [Fact]
    public void TestBadInput2()
    {
        Assert.Throws<BadInputException>(() => new Triangle(5, -5, 6));
    }

    [Fact]
    public void TestBadInput3()
    {
        Assert.Throws<BadInputException>(() => new Triangle(5, 5, -6));
    }

    [Fact]
    public void TestRectangle()
    {
        Assert.True(new Triangle(3, 4, 5).IsRectangle());
    }

    [Fact]
    public void TestNoRectangle()
    {
        Assert.False(new Triangle(3, 5, 5).IsRectangle());
    }

    [Fact]
    public void TestTriangleNoExist()
    {
        Assert.Throws<GeometryException>(() => new Triangle(1, 1, 5));
    }
}