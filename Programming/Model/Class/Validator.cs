static class Validator
{
    public static void AssertOnPositiveValue(int value,string mass)
    {
        if (value <= 0)
        {
            throw new ArgumentException(mass);
        }
    }
    public static void AssertOnPositiveValue(double value, string mass)
    {
        if (value <= 0)
        {
            throw new ArgumentException(mass);
        }
    }
    public static void AssertValueInRange(int value, int min, int max, string mass)
    {
        if (value < min || value > max)
        {
            throw new ArgumentException(mass);
        }
    }
    public static void AssertValueInRange(double value, int min, int max, string mass)
    {
        if (value < min || value > max)
        {
            throw new ArgumentException(mass);
        }
    }
}
