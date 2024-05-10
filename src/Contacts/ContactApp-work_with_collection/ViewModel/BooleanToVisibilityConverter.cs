using System.Globalization;
using System.Windows.Data;
using System.Windows;

/// <summary>
/// Класс для преобразования булевых значений в значение видимости кнопки.
/// </summary>
public sealed class BooleanToVisibilityConverter : IValueConverter
{
    /// <summary>
    /// Флаг для обозначения обратного значения.
    /// </summary>
    public bool IsReversed { get; set; }
    
    /// <summary>
    /// Флаг, определяющий нужно ли выделять место в макете под объект.
    /// </summary>
    public bool UseHidden { get; set; }

    /// <summary>
    /// Метод, возвращающий значение видимости объекта типом видимости. 
    /// </summary>
    /// <param name="value">Значение которое нужно преобразовать.</param>
    /// <param name="targetType">Тип объекта.</param>
    /// <param name="parameter">объект.</param>
    /// <param name="culture">Выбранный язык(культурные параметры).</param>
    /// <returns>Конвертированное значение видимости объекта.</returns>
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        var val = System.Convert.ToBoolean(value, CultureInfo.InvariantCulture);
        if (this.IsReversed)
        {
            val = !val;
        }
        if (val)
        {
            return Visibility.Visible;
        }
        return this.UseHidden ? Visibility.Hidden : Visibility.Collapsed;
    }

    /// <summary>
    /// Метод для конвертирования из типа видимости в тип(не используется).
    /// </summary>
    /// <param name="value">Значение(конвертируемое).</param>
    /// <param name="targetType">Тип объекта.</param>
    /// <param name="parameter">Объект.</param>
    /// <param name="culture">Культурные особенности.</param>
    /// <returns>Конвертированный объект.</returns>
    /// <exception cref="NotImplementedException">Так как метод не используется добавлено исключение не разработанного метода.</exception>
    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}