using Library.Figures;

namespace Library.Tests;

public class AnyFigureTest
{
    [Fact]
    public void TestAnyFigure()
    {
        Exception? exception = null;
        foreach (var figure in GetFigures())
        {
            var currentException = Record.Exception(() => figure.GetSquare());
            if (currentException != null)
            {
                exception = currentException;
            }
        }

        Assert.Null(exception);
    }

    private static List<Figure> GetFigures()
    {
        return new List<Figure> {
            new Circle(10),
            new Triangle(5, 6, 3),
            new Circle(7),
            new Triangle(1, 6, 6),
        };
    }
}