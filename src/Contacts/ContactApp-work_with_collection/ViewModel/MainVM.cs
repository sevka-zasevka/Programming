using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Collections.ObjectModel;
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
        private Contact _сurentContact;

        /// <summary>
        /// Список контактов, экземпляров класса <see cref="Contact"/>.
        /// </summary>
        private ObservableCollection<Contact> _contacts;

        /// <summary>
        /// Экземпляр класса <see cref="RelayCommand"/>.
        /// </summary>
        private RelayCommand _saveCommand;

        /// <summary>
        /// Экземпляр класса <see cref="RelayCommand"/>.
        /// </summary>
        private RelayCommand _loadCommand;

        private RelayCommand _addCommand;

        private RelayCommand _removeCommand;

        private RelayCommand _editCommand;

        private RelayCommand _applyCommand;

        /// <summary>
        /// Возвращает экземпляр класса <see cref="RelayCommand"/> для сериализации контакта.
        /// </summary>
        public RelayCommand SaveCommand
        {
            get
            {
                return _saveCommand ??
                  (_saveCommand = new RelayCommand(obj => ContactSerializer.SaveToFile(_contacts)));
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
                        _contacts = ContactSerializer.LoadFromFile();
                        Name = null;
                        PhoneNumber = null;
                        Email = null;
                    }));
            }
        }

        public RelayCommand AddCommand
        {
            get
            {
                return _addCommand ??
                    (_addCommand = new RelayCommand(obj =>
                    {
                        var contact = new Contact();
                        _contacts.Add(contact);
                        _сurentContact = contact;
                    }));
            }
        }

        public RelayCommand RemoveCommand
        {
            get
            {
                return _removeCommand ??
                    (_removeCommand = new RelayCommand(obj =>
                    {
                        for (int i = 0; i < _contacts.Count; i++)
                        {
                            if (_contacts[i] == _сurentContact)
                            {
                                _contacts.RemoveAt(i);
                                if (_contacts[i + 1] != null)
                                {
                                    _сurentContact = _contacts[i + 1];
                                    return;
                                }
                                if (_contacts.Count != 1)
                                {
                                    _сurentContact = _contacts[i - 1];
                                }
                                else
                                {
                                    _сurentContact = null;
                                }
                            }
                        }
                    }));
            }
        }

        public RelayCommand EditCommand
        {
            get
            {
                return _editCommand ??
                    (_editCommand = new RelayCommand(obj =>
                    {
                        var contact = new Contact();
                        _contacts.Add(contact);
                        _сurentContact = contact;
                    }));
            }
        }

        public RelayCommand ApplyCommand
        {
            get
            {
                return _applyCommand ??
                    (_applyCommand = new RelayCommand(obj =>
                    {
                        var contact = new Contact();
                        _contacts.Add(contact);
                        _сurentContact = contact;
                    }));
            }
        }

        /// <summary>
        /// Создает экземпляр <see cref="MainVM"/>.
        /// </summary>
        public MainVM()
        {
            _contacts = ContactSerializer.LoadFromFile();
        }

        /// <summary>
        /// Возвращает и задает имя контакта.
        /// </summary>
        public string Name
        {
            get
            {
                return _сurentContact.Name;
            }

            set
            {
                if (_сurentContact.Name != value)
                {

                    _сurentContact.Name = value;
                    OnPropertyChanged();
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
                return _сurentContact.PhoneNumber;
            }

            set
            {
                if (_сurentContact.PhoneNumber != value)
                {
                    _сurentContact.PhoneNumber = value;
                    OnPropertyChanged();
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
                return _сurentContact.Email;
            }

            set
            {
                if (_сurentContact.Email != value)
                {
                    _сurentContact.Email = value;
                    OnPropertyChanged();
                }
            }
        }

        public ObservableCollection<Contact> Contacts
        {
            get
            {
                return _contacts;
            }

            set
            {
                if (_contacts != value)
                {
                    _contacts = value;
                    OnPropertyChanged();
                }
            }
        }

        public Contact CurentContact
        {
            get
            {
                return _сurentContact;
            }

            set
            {
                if (_сurentContact != value)
                {
                    _сurentContact = value;
                    OnPropertyChanged();
                }
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
    }
}


