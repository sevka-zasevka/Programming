/// <summary>
/// Класс, хранящий часы, минуты и секунды.
/// </summary>
class Time
{
    /// <summary>
    /// Час, от 0 до 23.
    /// </summary>
    private int _hours;
    /// <summary>
    /// Минуты, от 0 до 59.
    /// </summary>
    private int _minutes;
    /// <summary>
    /// Секунды, от 0 до 59.
    /// </summary>
    private int _seconds;

    /// <summary>
    /// Возвращает и задает количество часов, от 0 до 23.
    /// </summary>
    public int Hours
    {
        get => _hours; 
        set 
        {
            Validator.AssertValueInRange(value, 0, 23, "Hours.Time");
            _hours = value; 
        }
    }

    /// <summary>
    /// Возвращает и задает количество минут, от 0 до 59.
    /// </summary>
    public int Minutes
    {
        get => _minutes; 
        set
        {
            Validator.AssertValueInRange(value, 0, 59, "Minutes.Time");
            _minutes = value;
        }
    }

    /// <summary>
    /// Возвращает и задает количество секунд, от 0 до 59.
    /// </summary>
    public int Seconds
    {
        get => _seconds; 
        set
        {
            Validator.AssertValueInRange(value, 0, 59, "Seconds.Time");
            _seconds = value;
        }
    }

    /// <summary>
    /// Создает пустой экземпляр класса <see cref="Time">.
    /// </summary>
    public Time()
    {

    }

    /// <summary>
    /// Создает экземпляр класса <see cref="Time">.
    /// </summary>
    /// <param name="hours">Часы, от 0 до 23.</param>
    /// <param name="minutes">Минуты, от 0 до 59.</param>
    /// <param name="seconds">Секунды, от 0 до 59.</param>
    public Time(int hours, int minutes, int seconds)
    {
        Hours = hours;
        Minutes = minutes;
        Seconds = seconds;
    }
}

