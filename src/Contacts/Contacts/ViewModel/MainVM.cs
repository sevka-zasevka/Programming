using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using View.Model;
using View.Model.Services;

namespace View.ViewModel
{
    public class MainVM : INotifyPropertyChanged
    {
        /// <summary>
        /// Экземпляр класса <see cref="Contact"/>.
        /// </summary>
        private Contact _contact;

        /// <summary>
        /// Экземпляр класса <see cref="RelayCommand"/>.
        /// </summary>
        private RelayCommand _saveCommand;

        /// <summary>
        /// Экземпляр класса <see cref="RelayCommand"/>.
        /// </summary>
        private RelayCommand _loadCommand;

        /// <summary>
        /// Возвращает экземпляр класса <see cref="RelayCommand"/> для сериализации контакта.
        /// </summary>
        public RelayCommand SaveCommand
        {
            get
            {
                return _saveCommand ??
                  (_saveCommand = new RelayCommand(obj => ContactSerializer.SaveToFile(_contact)));
            }
        }

        /// <summary>
        /// Возвращает экземпляр класса <see cref="RelayCommand"/> для десериализации контакта.
        /// </summary>
        public RelayCommand LoadCommand
        {
            get
            {
                return _loadCommand ??
                    (_loadCommand = new RelayCommand(obj =>
                    {
                        var contact = ContactSerializer.LoadFromFile();
                        Name = contact.Name;
                        PhoneNumber = contact.PhoneNumber;
                        Email = contact.Email;
                    }));
            }
        }

        /// <summary>
        /// Создает экземпляр <see cref="MainVM"/>.
        /// </summary>
        public MainVM()
        {
            _contact = new Contact();
            _contact = ContactSerializer.LoadFromFile();
        }

        /// <summary>
        /// Возвращает и задает имя контакта.
        /// </summary>
        public string Name
        {
            get
            {
                return _contact.Name;
            }

            set
            {
                if (_contact.Name != value)
                {

                    _contact.Name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }

        /// <summary>
        /// Возвращает и задает номер телефона контакта.
        /// </summary>
        public string PhoneNumber
        {
            get
            {
                return _contact.PhoneNumber;
            }

            set
            {
                if (_contact.PhoneNumber != value)
                {
                    _contact.PhoneNumber = value;
                    OnPropertyChanged(nameof(PhoneNumber));
                }
            }
        }

        /// <summary>
        /// Возвращает и задает электронную почту контакта.
        /// </summary>
        public string Email
        {
            get
            {
                return _contact.Email;
            }

            set
            {
                if (_contact.Email != value)
                {
                    _contact.Email = value;
                    OnPropertyChanged(nameof(Email));
                }
            }
        }

        /// <summary>
        /// Зажигается при обновлении свойств.
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Обновляет привязанные данные.
        /// </summary>
        /// <param name="prop">Имя свойства</param>
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}

 
