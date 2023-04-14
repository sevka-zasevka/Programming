using System.Drawing;
using System.Security.Cryptography;

class Ring
{
    private int _outerRadius;
    private int _innerRadius;

    public int OuterRadius
    {
        get => _outerRadius;
        set
        {
            Validator.AssertValueInRange(value, InnerRadius++, int.MaxValue, "OuterRadius.Ring");
            _outerRadius = value;
        }
    }

    public int InnerRadius
    {
        get => _innerRadius;
        set
        {
            Validator.AssertValueInRange(value, 1, OuterRadius--, "OuterRadius.Ring");
            _innerRadius = value;
        }
    }

    public Point2D Centre { get; set; }

    private static double Area(Ring ring)
    {
        double area = 3.14 * (ring.OuterRadius ^ 2) - 3.14 * (ring.InnerRadius ^ 2);
        return area;
    }
    public static int AllRingsCount { get; set; }

    public int Id { get; }

    public Ring()
    {

    }

    public Ring(int outerRadius, int innerRadius, int x, int y)
    {
        OuterRadius = outerRadius;
        InnerRadius = innerRadius;
        Centre = new Point2D(x, y);
        AllRingsCount++;
        Id = AllRingsCount;
    }
}
