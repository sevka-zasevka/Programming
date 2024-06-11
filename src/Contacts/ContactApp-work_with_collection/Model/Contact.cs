using ContactApp_work_with_collection.Model.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace View.Model
{
    /// <summary>
    /// Класс для хранения контактов.
    /// </summary>
    public class Contact : INotifyPropertyChanged, IDataErrorInfo
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
                            error = "Имя должно быть от 1 до 100 символов.";
                        }
                        break;

                    case nameof(PhoneNumber):

                        if (String.IsNullOrEmpty(PhoneNumber) || PhoneNumber.Length > 100)
                        {
                            error = "Номер телефона должен быть не длиннее 100 символов и может содержать только цифры или символы +-() .";
                        }
                        break;

                    case nameof(Email):
                        if (String.IsNullOrEmpty(Email) || Email.Length > 100 || !Email.Contains("@"))
                        {
                            error = "Email должен быть не длиннее 100 символов и должен содержать символ @ .";
                        }
                        break;
                }
                return error;
            }
        }

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
        /// Зажигается при обновлении свойств.
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Обновляет привязанные данные.
        /// О атрибуте CallerMemberName:
        /// Этот интерфейс позволяет свойству объекта уведомлять связанный 
        /// элемент управления об изменении свойства, чтобы элемент управления 
        /// мог отображать обновленные сведения. Удобно, что если переименовать свойства,
        /// то не нужно вставлять изменения в вызов метода, потому что CallerMemberName 
        /// сделает это сам.
        /// </summary>
        /// <param name="prop">Имя свойства.</param>
        private void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
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
