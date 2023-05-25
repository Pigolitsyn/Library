# Library for get square for Circle and Triangle

## To count square use next code: 

```csharp
// for triangle

new Tringle(3, 4, 5).GetSquare();

// for circle

new Circle(3).GetSquare();
```

notion: if you input incorrect data you can get follow exceptions: 
* BadInputException - if you try to make triangle or circle with negative values
* GeometryException - if you try to make triangle with one side bigger than both another sides together 

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

## SQL-Code to get ProductCategories relation

```sql
select P.Name, C.Name
from Product P
  left join Product2Category P2C on P2C.ProductId = P.Id
  left join Category C on P2C.CategoryId = C.Id
```
