class Point2D
{
    private int _x; 
    private int _y;
    public int X 
    { 
        get => _x;
        set 
        { 
            Validator.AssertOnPositiveValue(value, "X.Point2D"); 
            _x = value;
        }
    }

    public int Y
    {
        get => _y;
        set
        {
            Validator.AssertOnPositiveValue(value, "Y.Point2D");
            _y = value;
        }
    }

    public Point2D()
    {

    }

    public Point2D(int x, int y)
    {
        X = x;
        Y = y;
    }
}
