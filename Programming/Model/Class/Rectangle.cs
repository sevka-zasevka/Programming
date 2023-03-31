class Rectangle
{
    private double _length;
    private double _width;
    private Point2D _centre;
    private static int _allRectanglesCount;
    private readonly int _id;

    public double Length
    {
        get => _length;
        set
        {
            Validator.AssertOnPositiveValue(value, "Length.Rectangle");
            _length = value;
        }
    }

    public double Width
    {
        get => _width; 
        set
        {
            Validator.AssertOnPositiveValue(value, "Width.Rectangle");
            _width = value;
        }
    }

    public string Color { get; set; }

    public Point2D Centre
    {
        get => _centre;
        set
        {
            _centre = value;
        }
    }

    public static int AllRectanglesCount
    {
        get => _allRectanglesCount;
        set 
        {
            _allRectanglesCount = value;
        }
    }

    public int Id
    {
        get => _id;
        set
        {
            
        }
    }

    public Rectangle(double length, double width, string color, int x, int y)
    {
        Length = length;
        Width = width;
        Color = color;
        Centre = new Point2D (x, y);
        AllRectanglesCount++;
        _id = AllRectanglesCount;
    }

    public Rectangle()
    { 

    }
}