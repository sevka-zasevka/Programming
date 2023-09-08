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
        /// Адрес покупателя, до 500 символов.
        /// </summary>
        private string _adress;

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
        public string Adress
        {
            get 
            { 
                return _adress; 
            }

            set 
            {
                ValueValidator.AssertStringOnLength(value, 200, "Customer.Adress");
                _adress = value; 
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/>.
        /// </summary>
        /// <param name="fullname">Фио покупателя, до 200 символов.</param>
        /// <param name="adress">Адрес покупателя, до 500 символов.</param>
        public Customer(string fullname, string adress)
        {
            Fullname = fullname;
            Adress = adress;
        }
    }
}
