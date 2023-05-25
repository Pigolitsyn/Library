# Library for get square for Circle and Triangle

## To add figure you need a inherit Figure class like this and override GetSquare function

```csharp
using Library.Figures;

public class Square : Figure {
  private readonly double _side { get; set; }

  public Square(double side) {
    _side = side;
  }
  
  public override GetSquare() {
    return _side * _side;
  }
}
```
