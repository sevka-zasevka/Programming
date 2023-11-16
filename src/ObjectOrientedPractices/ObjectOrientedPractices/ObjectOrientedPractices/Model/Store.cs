using ObjectOrientedPractices.Services;
using ObjectOrientedPractices.View;
using ObjectOrientedPractices.View.Tabs;
using ObjectOrientedPractices.View.Controls;

namespace ObjectOrientedPractices.Model
{
    internal class Store
    {
        /// <summary>
        /// Список объектов класса <see cref="Item"/>.
        /// </summary>
        private List<Item> _items;
        /// <summary>
        /// Список объектов класса <see cref="Customer"/>.
        /// </summary>
        private List<Customer> _customers;

        /// <summary>
        /// Возвращает и задает список объектов класса <see cref="Item"/>.
        /// </summary>
        public List<Item> Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;
            }
        }

        /// <summary>
        /// Возвращает и задает список объектов класса <see cref="Customer"/>
        /// </summary>
        public List<Customer> Customers
        {
            get
            {
                return _customers;
            }
            set
            {
                _customers = value;
            }

        }

        /// <summary>
        /// Создает пустой экземпляр класса <see cref="Store"/>.
        /// </summary>
        public Store()
        {
            Items = new List<Item>();
            Customers = new List<Customer>();
        }
    }
}

