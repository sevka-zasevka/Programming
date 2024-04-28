using System.Globalization;
using System.Windows.Data;
using System.Windows;

/// <summary>
/// Класс для преобразования булевых значений в значение видимости кнопки.
/// </summary>
public sealed class BooleanToVisibilityConverter : IValueConverter
{
    public bool IsReversed { get; set; }
    public bool UseHidden { get; set; }
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
    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}