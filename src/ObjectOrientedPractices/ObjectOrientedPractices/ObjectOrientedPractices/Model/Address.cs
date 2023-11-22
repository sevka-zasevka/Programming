using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractices.Services;

namespace ObjectOrientedPractices.Model
{
    public class Address:ICloneable
    {
        public event EventHandler AddressChanged;
        /// <summary>
        /// Почтовый индекс, целое шестизначное число.
        /// </summary>
        private int _index;
        /// <summary>
        /// Название страны/региона, не более 50 символов.
        /// </summary>
        private string _country;
        /// <summary>
        /// Название города(населенного пункта), не более 50 символов.
        /// </summary>
        private string _city;
        /// <summary>
        /// Название улицы, не более 100 символов.
        /// </summary>
        private string _street;
        /// <summary>
        /// Номер дома, не более 10 символов.
        /// </summary>
        private string _building;
        /// <summary>
        /// Номер квартиры/помещения, не более 10 символов.
        /// </summary>
        private string _apartment;

        /// <summary>
        /// Возвращает и задает почтовый индекс. 
        /// </summary>
        public int Index
        {
            get 
            { 
                return _index; 
            }

            set
            {
                ValueValidator.CheckIntValue(100000, 999999, value, "Address.Index");
                if(_index!=value)
                {
                    _index = value;
                    AddressChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Возвращает и задает название страны/региона.
        /// </summary>
        public string Country
        {
            get
            {
                return _country;
            }

            set
            {
                ValueValidator.AssertStringOnLength(value, 50, "Address.Country");
                if (_country != value)
                {
                    _country = value;
                    AddressChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Возвращает и задает название города(населённого пункта).
        /// </summary>
        public string City
        {
            get 
            {
                return _city;
            }

            set
            {
                ValueValidator.AssertStringOnLength(value, 50, "Address.City");
                if (_city != value)
                {
                    _city = value;
                    AddressChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Возвращает и задает название улицы.
        /// </summary>
        public string Street
        {
            get
            {
                return _street;
            }

            set
            {
                ValueValidator.AssertStringOnLength(value, 100, "Address.Street");
                if (_street != value)
                {
                    _street = value;
                    AddressChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Возвражает и задает номер дома.
        /// </summary>
        public string Building
        {
            get
            {
                return _building;
            }

            set
            {
                ValueValidator.AssertStringOnLength(value, 10, "Address.Building");
                if (_building != value)
                {
                    _building = value;
                    AddressChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Возвращае и задает номер квартиры/помещения.
        /// </summary>
        public string Apartment
        {
            get
            {
                return _apartment;
            }

            set
            {
                ValueValidator.AssertStringOnLength(value, 10, "Address.Apartment");
                if (_apartment != value)
                {
                    _apartment = value;
                    AddressChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Создает объект класса <see cref="Address"/>.
        /// </summary>
        /// <param name="index">Почтовый индекс, шестизначное число.</param>
        /// <param name="country">Название страны/региона, не более 50 символов.</param>
        /// <param name="city">Название города(населенного пункта), не более 50 символов.</param>
        /// <param name="street">Название улицы, не более 100 символов.</param>
        /// <param name="building">Номер дома, не более 10 символов.</param>
        /// <param name="apartment">Номер квартиры/помещения, не более 10 символов.</param>
        public Address()
        {
            Index = 606060;
            Country = "Country";
            City = "City";
            Street = "Street";
            Building = "00";
            Apartment = "00";
        }

        public Address(int index, string country, string city, string street, string building, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }

        /// <summary>
        /// Метод для копирования исходного объекта класса <see cref="Address"/>.
        /// </summary>
        /// <returns>Новый объект класса <see cref="Address"/> с такими же значениями полей, как у исходного объекта.</returns>
        public object Clone() 
        { 
            return new Address(this.Index, this.Country, this.City, this.Street, this.Building, this.Apartment); 
        }

        /// <summary>
        /// Метод для сравнения двух объектов класса <see cref="Address"/> по индексу.
        /// </summary>
        /// <param name="other">Объект класса <see cref="Address"/>.</param>
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
            var item2 = (Address)other;
            return (this.Index == item2.Index);
        }
    }
}
