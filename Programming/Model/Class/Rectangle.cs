class Rectangle: ICloneable
{
    private static int _allRectanglesCount;
    private int _length;
    private int _width;

    public int Length
    {
        get => _length;
        set
        {
            Validator.AssertOnPositiveValue(value, "Length.Rectangle");
            _length = value;
        }
    }

    public int Width
    {
        get => _width; 
        set
        {
            Validator.AssertOnPositiveValue(value, "Width.Rectangle");
            _width = value;
        }
    }

    public string Color { get; set; }

    public Point2D Centre { get; set; }

    public static int AllRectanglesCount => _allRectanglesCount;

    public int Id { get; }

    public Rectangle(int length, int width, string color, int x, int y)
    {
        Length = length;
        Width = width;
        Color = color;
        Centre = new Point2D (x, y);
        _allRectanglesCount ++;
        Id = AllRectanglesCount;
    }

    public Rectangle()
    { 

    }

    public object Clone()
    {
        return MemberwiseClone();
    }
}