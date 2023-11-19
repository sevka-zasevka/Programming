using ObjectOrientedPractices.Services;
using System;

namespace ObjectOrientedPractices.Model
{
    internal class Cart:ICloneable
    {
        /// <summary>
        /// Список товаров.
        /// </summary>
        private List<Item> _curentItem;

        /// <summary>
        /// Возвращает и задает список товаров.
        /// </summary>
        public List<Item> CurentItem
        {
            get { return _curentItem; }
            set { _curentItem = value; }
        }

        /// <summary>
        /// Возвращает стоимость всех товаров в корзине.
        /// </summary>
        public double Amount
        {
            get
            {
                if (CurentItem==null)
                {
                    return 0.0;
                }
                double cost = 0;
                for (int i = 0; i< _curentItem.Count; i ++)
                {
                    cost += CurentItem[i].Cost;
                }
                return Math.Round(cost, 2); ;
            }
        }

        /// <summary>
        /// Создаёт объект класса <see cref="Cart"/> с пустым списком объектов класса <see cref="Item">.
        /// </summary>
        public Cart() 
        {
            CurentItem = new List<Item>();
        }

        /// <summary>
        /// Создаёт объект класса <see cref="Cart"/> с пустым списком объектов класса <see cref="Item">.
        /// </summary>
        public Cart(List<Item> items)
        {
            CurentItem = items;
        }

        /// <summary>
        /// Метод для копирования объекта класса <see cref="Cart"/>
        /// </summary>
        /// <returns>Новый объект классса <see cref="Cart"/> со значениями полей как у исходного объекта.</returns>
        public object Clone() 
        { 
            return new Cart(this.CurentItem); 
        }
    }
}
