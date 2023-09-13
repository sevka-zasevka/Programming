using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractices.Services
{
    /// <summary>
    /// Класс, хранащий методы для валидации значений. 
    /// </summary>
    internal class ValueValidator
    {
        /// <summary>
        /// Метод, проверяющий целочисленные значения.
        /// </summary>
        /// <param name="minValue">Минимальное значение.</param>
        /// <param name="maxValue">Максимальное значение.</param>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="propertyName">Место вызова метода.</param>
        /// <exception cref="ArgumentException"></exception>
        public static void CheckIntValue(int minValue, int maxValue, int value, string propertyName)
        {
            if (value < minValue || value > maxValue || value == 0)
            {
                throw new ArgumentException(propertyName+" ожидается стоимость от 0 до "+maxValue+".");
            }
        }

        /// <summary>
        /// Метод, проверяющий вещественные значения.
        /// </summary>
        /// <param name="minValue">Минимальное значение.</param>
        /// <param name="maxValue">Максимальное значение.</param>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="propertyName">Место вызова метода.</param>
        /// <exception cref="ArgumentException"></exception>
        public static void CheckDoubleValue(int minValue, int maxValue, double value, string propertyName)
        {
            if (value < minValue || value > maxValue || value == 0)
            {
                throw new ArgumentException(propertyName + " ожидается стоимость от 0 до " + maxValue + ".");
            }
        }

        /// <summary>
        /// Метод проверяющий количество знаков в строке.
        /// </summary>
        /// <param name="value">Проверяемая строка</param>
        /// <param name="maxLenght">Максимально количество символов.</param>
        /// <param name="propertyName">Место вызова метода.</param>
        /// <exception cref="ArgumentException"></exception>
        public static void AssertStringOnLength(string value, int maxLenght, string propertyName)
        {
            if (value.Length > maxLenght || value.Length == 0)
            {
                throw new ArgumentException(propertyName + " ожидается значение больше 0 и до " + maxLenght + " символов.");
            }
        }
    }
}
