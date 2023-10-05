using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractices.Services;

namespace ObjectOrientedPractices.Model
{
    public class Address
    {
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
                _index = value;
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
                _country = value;
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
                _city = value;
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
                _street = value;
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
                _building = value;
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
                _apartment = value;
            }
        }

        /// <summary>
        /// Создает пустой объект класса <see cref="Address"/>.
        /// </summary>
        public Address()
        {

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
        public Address(int index, string country, string city, string street, string building, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }
    }
}
