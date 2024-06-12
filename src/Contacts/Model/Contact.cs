using System.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Model
{
    /// <summary>
    /// Класс для хранения контактов.
    /// </summary>
    public class Contact : ObservableObject, IDataErrorInfo
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

        /// <summary>
        /// Возвращает и задает Имя контакта.
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(IsContactCorrect));
            }
        }

        /// <summary>
        /// Возвращает и задает телефонный номер контакта.
        /// </summary>
        public string PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                _phoneNumber = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(IsContactCorrect));
            }
        }

        /// <summary>
        /// Возвращает и задает электронную почту контакта.
        /// </summary>
        public string Email
        {
            get => _email;
            set
            {
                _email = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(IsContactCorrect));
            }
        }

        /// <summary>
        /// Возвращает ошибку.
        /// </summary>
        public string Error => "";

        /// <summary>
        /// Возвращает строку, содержащую ошибку.
        /// </summary>
        /// <returns>Строка, содержащая информацию об ошибке.</returns>
        public string this[string propertyName]
        {
            get
            {
                string error = string.Empty;
                switch (propertyName)
                {
                    case nameof(Name):
                        if (String.IsNullOrEmpty(Name) || Name.Length > 100)
                        {
                            error = "The name must be between 1 and 100 characters.";
                        }
                        break;

                    case nameof(PhoneNumber):

                        if (String.IsNullOrEmpty(PhoneNumber) || PhoneNumber.Length > 100)
                        {
                            error = "The phone number must be less than 100 characters " +
                                "and can only contain numbers or +-() symbols.";
                        }
                        break;

                    case nameof(Email):
                        if (String.IsNullOrEmpty(Email) || Email.Length > 100 || !Email.Contains("@"))
                        {
                            error = "Email must be less than 100 characters and must contain the @ symbol.";
                        }
                        break;
                }
                return error;
            }
        }

        /// <summary>
        /// Возвращает значение корректности значения контакта.
        /// </summary>
        public bool IsContactCorrect
        {
            get
            {
                foreach (var property in typeof(Contact).GetProperties())
                {
                    if (this[property.Name] != string.Empty)
                    {
                        return false;
                    }
                }

                return true;
            }
        }

        
        /// <summary>
        /// Создает экземпляр класса <see cref="Contact"/>.
        /// </summary>
        /// <param name="name">Имя.</param>
        /// <param name="phoneNumber">Номер телефона.</param>
        /// <param name="email">Элетронная почта.</param>
        public Contact(string name, string phoneNumber, string email)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        /// <summary>
        /// Создает пустой экземпляр класса <see cref="Contact"/>.
        /// </summary>
        public Contact()
        {

        }
    }
}
