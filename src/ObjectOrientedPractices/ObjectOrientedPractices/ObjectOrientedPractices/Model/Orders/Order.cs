﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractices.Model.Enums;
using ObjectOrientedPractices.Services;

namespace ObjectOrientedPractices.Model.Orders
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
        /// Скидка на заказ.
        /// </summary>
        private double _discountAmount;
        /// <summary>
        /// Конечная стоимость заказа.
        /// </summary>
        private double _total;

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
        /// Возвращает и задает скидку на заказ.
        /// </summary>
        public double DiscountAmount
        {
            get { return _discountAmount; }
            set { _discountAmount = value; }
        }

        /// <summary>
        /// Возвращает конечную стоимость заказа.
        /// </summary>
        public double Total
        {
            get 
            {
                double val = Amount - DiscountAmount;
                return val; 
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

        /// <summary>
        /// Конструктор класса <see cref="Order"/> без параметров.
        /// </summary>
        public Order()
        {

        }

        /// <summary>
        /// Метод для сравнения двух объектов класса <see cref="Order"/> по списку товаров класса <see cref="Item"/>.
        /// </summary>
        /// <param name="other">Объект класса <see cref="Order"/>.</param>
        /// <returns>true - объекты равны, false - объекты не равны.</returns>
        public override bool Equals(object other)
        {
            if (other == null)
            {
                return false;
            }
            if (other is not Item)
            {
                return false;
            }
            if (object.ReferenceEquals(this, other))
            {
                return true;
            }
            var item2 = (Order)other;
            return (this.Items == item2.Items);
        }
    }
}
