using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractices.Model.Enums;

namespace ObjectOrientedPractices.Model.Discounts
{
    internal class PercentDiscount : IDiscount
    {
        /// <summary>
        /// Категория товара.
        /// </summary>
        private Category _category;
        /// <summary>
        /// Накопленный процент скидки.
        /// </summary>
        private int _percent = 1;
        /// <summary>
        /// Стимость уже купленных товаров категории(если больше 1000, то увеличивается процент на 1).
        /// </summary>
        private double _sum;
        private string _info;

        /// <summary>
        /// Возвращает и задает категорию товара.
        /// </summary>
        public Category Category
        {
            get { return _category; }
            set { _category = value; }
        }

        /// <summary>
        /// Возвращает и задает процент скидки на категорию, не дольше 10.
        /// </summary>
        public int Percent
        {
            get { return _percent; }
            set { _percent = value; }
        }

        /// <summary>
        /// Возвращает и задает накопленную сумму стоимости уже совершенных заказов.
        /// </summary>
        public double Sum
        {
            get { return _sum; }
            set { _sum = value; }
        }

        /// <summary>
        /// Метод для вывода информации пользователю.
        /// </summary>
        /// <returns>Возвращает строку с категорией и процентом скидки на неё.</returns>
        public string Info
        {
            get => "Процентная " + Category.ToString() + " - " + Percent.ToString() + " процентов.";
        }

        /// <summary>
        /// Метод считает возможную стидку по списку товаров класса <see cref="Item"/>.
        /// </summary>
        /// <param name="items">Список товаров класса <see cref="Item"/>.</param>
        /// <returns>Вещественное значение скидки по списку товаров класса <see cref="Item"/>.</returns>
        public double Calculate(List<Item> items)
        {
            if (Percent == 0)
            {
                return 0.0;
            }
            double amount = 0;
            foreach (var item in items)
            {
                if (item.Category == Category)
                {
                    amount += item.Cost;
                }
            }
            return amount / 100 * Percent;
        }

        /// <summary>
        /// Метод подсчитывает размер скидки.
        /// </summary>
        /// <param name="items">Список товаров класса <see cref="Item"/>.</param>
        /// <returns>Вещественное значение скидки по списку товаров класса <see cref="Item"/>.</returns>
        public double Apply(List<Item> items)
        {
            return Calculate(items);
        }

        /// <summary>
        /// Метод обновляет данные по проценту скидки и накопленной сумме стоимости покупок.
        /// </summary>
        /// <param name="items">Список товаров класса <see cref="Item"/>.</param>
        public void Update(List<Item> items)
        {
            if (Percent < 10)
            {

                double amount = 0;
                foreach (var item in items)
                {
                    if (item.Category == Category)
                    {
                        amount += item.Cost;
                    }
                }

                Sum += amount;
                while (Sum > 1000)
                {
                    Percent += 1;
                    if (Percent == 10)
                    {
                        break;
                    }
                    Sum -= 1000;
                }
            }
        }
    }
}
