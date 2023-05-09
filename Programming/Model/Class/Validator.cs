/// <summary>
/// Класс, хранящий методы для валидации числовых значений.
/// </summary>
static class Validator
{
    /// <summary>
    /// Метод, проверяющий целочисленное число на положительное значение.
    /// </summary>
    /// <param name="value">Проверяемое число.</param>
    /// <param name="mass">Сообщение для определения места вызова.</param>
    /// <exception cref="ArgumentException"></exception>
    public static void AssertOnPositiveValue(int value,string mass)
    {
        if (value <= 0)
        {
            throw new ArgumentException(mass);
        }
    }

    /// <summary>
    /// Метод, проверяющий вещественное число на положительное значение.
    /// </summary>
    /// <param name="value">Проверяемое число.</param>
    /// <param name="mass">Сообщение для определения места вызова.</param>
    /// <exception cref="ArgumentException"></exception>
    public static void AssertOnPositiveValue(double value, string mass)
    {
        if (value <= 0)
        {
            throw new ArgumentException(mass);
        }
    }

    /// <summary>
    /// Метод, проверяющий целочисленное число на вхождение в диапазон.
    /// </summary>
    /// <param name="value">Проверяемое число.</param>
    /// <param name="min">Нижняя граница диапазона.</param>
    /// <param name="max">Верхняя граница диапазона.</param>
    /// <param name="mass">Сообщение для определения места вызова</param>
    /// <exception cref="ArgumentException"></exception>
    public static void AssertValueInRange(int value, int min, int max, string mass)
    {
        if (value < min || value > max)
        {
            throw new ArgumentException(mass);
        }
    }

    /// <summary>
    /// Метод, проверяющий вещественное число на вхождение в диапазон.
    /// </summary>
    /// <param name="value">Проверяемое число.</param>
    /// <param name="min">Нижняя граница диапазона.</param>
    /// <param name="max">Верхняя граница диапазона.</param>
    /// <param name="mass">Сообщение для определения места вызова</param>
    /// <exception cref="ArgumentException"></exception>
    public static void AssertValueInRange(double value, int min, int max, string mass)
    {
        if (value < min || value > max)
        {
            throw new ArgumentException(mass);
        }
    }
}
