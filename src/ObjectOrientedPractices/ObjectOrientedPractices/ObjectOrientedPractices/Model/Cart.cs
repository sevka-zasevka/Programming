using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractices.Services;

namespace ObjectOrientedPractices.Model
{
    internal class Cart
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
                return cost;
            }
        }

        /// <summary>
        /// Создаёт объект класса <see cref="Cart"/> с пустым списком объектов класса <see cref="Item">.
        /// </summary>
        public Cart() 
        {
            _curentItem = new List<Item>();
        }
    }
}
