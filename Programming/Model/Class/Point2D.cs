/// <summary>
/// Класс, хранящий координаты x и y точки.
/// </summary>
class Point2D
{
    /// <summary>
    /// Координата точки по x, только положительное значение.
    /// </summary>
    private int _x; 
    /// <summary>
    /// Координата точки по y, только пооложительное значение.
    /// </summary>
    private int _y;

    /// <summary>
    /// Возращает и задает координату точки по x, только положительное значение.
    /// </summary>
    public int X 
    { 
        get => _x;
        set 
        { 
            Validator.AssertOnPositiveValue(value, "X.Point2D"); 
            _x = value;
        }
    }

    /// <summary>
    /// Возвращает и задает координату точки по y, только положительное значение. 
    /// </summary>
    public int Y
    {
        get => _y;
        set
        {
            Validator.AssertOnPositiveValue(value, "Y.Point2D");
            _y = value;
        }
    }

    /// <summary>
    /// Создает пустой экземпляр класса <see cref="Point2D">
    /// </summary>
    public Point2D()
    {

    }

    /// <summary>
    /// Создает экземпляр класса <see cref="Point2D">
    /// </summary>
    /// <param name="x">Координата точки по x, только положительное значение.</param>
    /// <param name="y">Координата точки по y, тольео положительные значение.</param>
    public Point2D(int x, int y)
    {
        X = x;
        Y = y;
    }
}
