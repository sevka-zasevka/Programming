class Point2D
{
    readonly int _x;
    readonly int _y;

    public int X
    { 
        get => _x;
        set
        { 

        }
    }

    public int Y
    {
        get => _y;
        set
        {
          
        }
    }

    public Point2D()
    {

    }

    public Point2D(int x, int y)
    {
        Validator.AssertOnPositiveValue(x, "X.Point2D");
        _x = x;
        Validator.AssertOnPositiveValue(y, "Y.Point2D");
        _y = y;
    }
}
