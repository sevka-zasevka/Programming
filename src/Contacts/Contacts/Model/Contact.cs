using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Model
{
    /// <summary>
    /// Класс для хранения контактов.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Имя контакта.
        /// </summary>
        private string _name;
        /// <summary>
        /// Телефон контакта.
        /// </summary>
        private string _phoneNumber;
        /// <summary>
        /// Электронная почта контакта.
        /// </summary>
        private string _email;

        public string Name 
        { 
            get => _name; 
            set => _name = value;
        }

        public string PhoneNumber
        {
            get => _phoneNumber;
            set => _phoneNumber = value;
        }

        public string Email
        {
            get => _email;
            set => _email = value;
        }

        public Contact(string name, string phoneNumber, string email)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public Contact()
        {

        }
    }
}
