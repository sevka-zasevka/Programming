class Time
{
    private int _hours;
    private int _minutes;
    private int _seconds;

    public int Hours
    {
        get => _hours; 
        set 
        {
            Validator.AssertValueInRange(value, 0, 23, "Hours.Time");
            _hours = value; 
        }
    }

    public int Minutes
    {
        get => _minutes; 
        set
        {
            Validator.AssertValueInRange(value, 0, 59, "Minutes.Time");
            _minutes = value;
        }
    }

    public int Seconds
    {
        get => _seconds; 
        set
        {
            Validator.AssertValueInRange(value, 0, 59, "Seconds.Time");
            _seconds = value;
        }
    }

    public Time(int hours, int minutes, int seconds)
    {
        Hours = hours;
        Minutes = minutes;
        Seconds = seconds;
    }
    public Time()
    { 
    
    }
}

