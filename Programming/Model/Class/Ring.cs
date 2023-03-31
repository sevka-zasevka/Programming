using System.Drawing;
using System.Security.Cryptography;

class Ring
{
    private Point2D _centre;
    private int _outerRadius;
    private int _innerRadius;
    private static int _allRingsCount;
    private readonly int _id;

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

    public Point2D Centre
    {
        get => _centre;
        set
        {
            _centre = value;
        }
    }

    private static double Area(Ring ring)
    {
        double area = 3.14 * (ring.OuterRadius ^ 2) - 3.14 * (ring.InnerRadius ^ 2);
        return area;
    }
    public static int AllRingsCount
    {
        get => _allRingsCount;
        set
        {
            _allRingsCount = value;
        }
    }

    public int Id
    {
        get => _id;
        set
        {

        }
    }

    public Ring()
    {

    }

    public Ring(int outerRadius, int innerRadius, int x, int y)
    {
        OuterRadius = outerRadius;
        InnerRadius = innerRadius;
        Centre = new Point2D(x, y);
        AllRingsCount++;
        _id = AllRingsCount;
    }
}
