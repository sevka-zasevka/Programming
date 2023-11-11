using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractices.Services;

namespace ObjectOrientedPractices.Model
{
    internal class Order
    {
        /// <summary>
        /// id заказа, уникальный.
        /// </summary>
        private int _id = IdGenerator.GetNextId();
        /// <summary>
        /// Дата создания заказа.
        /// </summary>
        private DateTime _dateCreation = DateTime.Today;
        /// <summary>
        /// Адрес доставки заказа, объект класса <see cref="Address"/>.
        /// </summary>
        private Address _orderAddress;
        /// <summary>
        /// Список объектов класса <see cref="Item">
        /// </summary>
        private List<Item> _items;
        /// <summary>
        /// Цена заказа.
        /// </summary>
        private double _amount;
        /// <summary>
        /// Статус заказа.
        /// </summary>
        private OrderStatus _status;
        /// <summary>
        /// Фио заказавшего.
        /// </summary>
        private string _fullnameCustomer;

        /// <summary>
        /// Возвращает уникальный индетефикатор заказа.
        /// </summary>
        public int Id 
        { 
            get 
            { 
                return _id; 
            } 
        }

        /// <summary>
        /// Возвращает дату создания заказа.
        /// </summary>
        public DateTime DateCreation 
        {
            get 
            { 
                return _dateCreation; 
            } 
        }

        /// <summary>
        /// Возвращает и задаёт адрес доставки заказа.
        /// </summary>
        public Address OrderAddress
        {
            get
            {
                return _orderAddress;
            }

            set
            {
                _orderAddress = value;
            }
        }

        /// <summary>
        /// Возвращает и задает список товаров, объектов класса <see cref="Item">
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
        /// Возвращает стоимость заказа.
        /// </summary>
        public double Amount
        {
            get
            {
                if (_items == null)
                {
                    return 0.0;
                }
                double cost = 0;
                for (int i = 0; i < _items.Count; i++)
                {
                    cost += _items[i].Cost;
                }
                return Math.Round(cost, 2);
            }
        }

        /// <summary>
        /// Возвращает и задает статус заказа.
        /// </summary>
        public OrderStatus Status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
            }
        }

        /// <summary>
        /// Возвращвет и задает полное имя заказавщего заказ покупателя.
        /// </summary>
        public string FullnameCustomer
        {
            get
            {
                return _fullnameCustomer;
            }
            set
            {
                _fullnameCustomer = value;
            }
        }

        /// <summary>
        /// Создает объект класса <see cref="Order"/>.
        /// </summary>
        public Order(Customer customer)
        {
            OrderAddress = customer.Address;
            Items = new List<Item>();
            Status = OrderStatus.New;
            FullnameCustomer = customer.Fullname;
        }

    }
}
