using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractices.Model.Discounts
{
    internal class PointsDiscount : IDiscount
    {
        /// <summary>
        /// Количество накопленных баллов.
        /// </summary>
        private int _points;
        /// <summary>
        /// информация о количестве накопленных баллов.
        /// </summary>
        private string _info;

        /// <summary>
        /// Возвращает и задает количество накопленных баллов.
        /// </summary>
        public int Points
        {
            get { return _points; }
            set { _points = value; }
        }

        /// <summary>
        /// Метод для вывода информации о количестве баллов пользователю.
        /// </summary>
        /// <returns>Возвращает строку с количеством доступлых баллов.</returns>
        public string Info
        {
            get => "Info: Накопительная  - " + Points + " баллов";
        }

        /// <summary>
        /// Метод подстчитывает бозможную скидку по списку товаров класса <see cref="Item"/>.
        /// </summary>
        /// <param name="items">Список товаров класса <see cref="Item"/>.</param>
        /// <returns>Вещественное значение скидки.</returns>
        public double Calculate(List<Item> items)
        {
            if (Points == 0)
            {
                return 0;
            }
            double amount = 0;
            foreach (Item item in items)
            {
                amount = amount + item.Cost;
            }
            double max = amount / 100 * 30;
            double discount = amount - Points;

            if (discount > max)
            {
                discount = max;
                return discount;
            }

            return discount;
        }

        /// <summary>
        /// Метод подсчитывает размер скидки и в соответствии с правилами уменьшает количество баллов.
        /// </summary>
        /// <param name="items">Список товаров класса <see cref="Item"/>.</param>
        /// <returns>Вещественное значения скидки.</returns>
        public double Apply(List<Item> items)
        {
            if (Points == 0)
            {
                return 0;
            }
            double amount = 0;
            foreach (Item item in items)
            {
                amount = amount + item.Cost;
            }
            double max = amount / 100 * 30;
            double discount = amount - Points;

            if (discount > max)
            {
                discount = max;
                Points = Points - (int)max;
                return discount;
            }
            Points = 0;
            return discount;
        }

        /// <summary>
        /// Метод увеличивает количество баллов, согласно правилам.
        /// </summary>
        /// <param name="items">Список товаров класса <see cref="Item"/>.</param>
        public void Update(List<Item> items)
        {
            double amount = 0;
            foreach (Item item in items)
            {
                amount = amount + item.Cost;
            }
            int plus = (int)((amount / 100) * 10);
            Points = Points + plus;
        }
    }
}
