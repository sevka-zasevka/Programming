using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractices.Services;

namespace ObjectOrientedPractices.Model
{
    /// <summary>
    /// Класс, хранящий id, ФИО и адресс покупателя.
    /// </summary>
    internal class Customer
    {
        /// <summary>
        /// id покупателя, уникальный.
        /// </summary>
        private int _id = IdGenerator.GetNextId();
        /// <summary>
        /// ФИО покупателя, до 200 символов.
        /// </summary>
        private string _fullname;
        /// <summary>
        /// Адрес покупателя, объект класса <see cref="Address"/>.
        /// </summary>
        private Address _address;
        /// <summary>
        /// Корзина покупателя, объект класса <see cref="Cart"/>.
        /// </summary>
        private Cart _cart;

        /// <summary>
        /// Возвращает id покупателя, уникальный
        /// </summary>
        public int Id
        { 
            get 
            { 
                return _id; 
            } 
        }
        /// <summary>
        /// Возвращает и задает ФИО покупателя. 
        /// </summary>
        public string Fullname
        {
            get 
            { 
                return _fullname; 
            }
            
            set 
            {
                ValueValidator.AssertStringOnLength(value, 200, "Customer.Fullname");
                _fullname = value; 
            }
        }

        /// <summary>
        /// Возвращает и задает Адрес покупателя.
        /// </summary>
        public Address Address
        {
            get 
            { 
                return _address; 
            }

            set 
            {
                _address = value; 
            }
        }

        /// <summary>
        /// Возвращает и задаёт корзину покупателя.
        /// </summary>
        public Cart Cart
        {
            get
            {
                return _cart;
            }
            set
            {
                _cart = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/>.
        /// </summary>
        /// <param name="fullname">Фио покупателя, до 200 символов.</param>
        public Customer(string fullname)
        {
            Fullname = fullname;
            Address = new Address();
            Cart = new Cart();
        }
    }
}
