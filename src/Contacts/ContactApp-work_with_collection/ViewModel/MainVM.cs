using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using View.Model;
using View.Model.Services;
using System.Reflection.Metadata;

namespace View.ViewModel
{
    /// <summary>
    /// Класс viewModel, соединяющий уровни View и Model.
    /// </summary>
    public class MainVM : INotifyPropertyChanged
    {
        /// <summary>
        /// Экземпляр класса <see cref="Contact"/>.
        /// </summary>
        private Contact _сurentContact;

        /// <summary>
        /// Экземпляр класса <see cref="Contact"/>.
        /// </summary>
        private Contact _editedContact;

        /// <summary>
        /// Список контактов, экземпляров класса <see cref="Contact"/>.
        /// </summary>
        private ObservableCollection<Contact> _contacts;

        /// <summary>
        /// Команда добавления объекта.
        /// </summary>
        private RelayCommand _addCommand;

        /// <summary>
        /// Команда удаления объекта.
        /// </summary>
        private RelayCommand _removeCommand;

        /// <summary>
        /// Команда редактирования объекта.
        /// </summary>
        private RelayCommand _editCommand;

        /// <summary>
        /// Команда сохранения созданного или отредактирононового объекта.
        /// </summary>
        private RelayCommand _applyCommand;

        /// <summary>
        /// Флаг для доступа к текстбоксам.
        /// </summary>
        private bool _isReadOnly;

        /// <summary>
        /// Флаг для пометки редактирования объекта.
        /// </summary>
        private bool _isEditing;

        /// <summary>
        /// Флаг для видимости кнопки Apply.
        /// </summary>
        private bool _isVisible;

        /// <summary>
        /// Сшздает новый объект.
        /// </summary>
        public RelayCommand AddCommand
        {
            get
            {
                return _addCommand ??
                    (_addCommand = new RelayCommand(obj =>
                    {
                        CurentContact = new Contact();
                        IsReadOnly = false;
                        IsVisible = true;
                    },
                    (obj)=>(IsReadOnly!=false)));
            }
        }

        /// <summary>
        /// Удаляет выбранный объект.
        /// Сохраняет в файл.
        /// </summary>
        public RelayCommand RemoveCommand
        {
            get
            {
                return _removeCommand ??
                    (_removeCommand = new RelayCommand(obj =>
                    {
                        int n = Contacts.IndexOf(_сurentContact);
                        Contacts.RemoveAt(n);
                        ContactSerializer.SaveToFile(Contacts);
                        if (Contacts.Count == 0)
                        {
                            CurentContact = null;
                            EditedContact = null;
                            return;
                        }
                        if (Contacts.Count > n)
                        {
                            CurentContact = Contacts[n];
                        }
                        else
                        {
                            CurentContact = Contacts[n - 1];
                        }
                    },
                    (obj)=>(Contacts.Count > 0 && CurentContact != null &&
                              Contacts.IndexOf(CurentContact) != -1 &&
                              IsReadOnly!=false)));
            }
        }

        /// <summary>
        /// Открывает доступ к редактированию выбранного объекта.
        /// </summary>
        public RelayCommand EditCommand
        {
            get
            {
                return _editCommand ??
                    (_editCommand = new RelayCommand(obj =>
                    {
                        if (CurentContact != null)
                        {
                            IsEditing = true;
                            IsReadOnly = false;
                            IsVisible = true;
                        }
                    },
                    (obj)=>(IsReadOnly!=false)));
            }
        }

        /// <summary>
        /// Добавляет созданный объект или созраняет изменения.
        /// Сохраняет в файл.
        /// </summary>
        public RelayCommand ApplyCommand
        {
            get
            {
                return _applyCommand ??
                    (_applyCommand = new RelayCommand(obj =>
                    {
                        IsReadOnly = true;
                        if(IsEditing!=true)
                        {
                            CurentContact = CopyContact(EditedContact);
                            Contacts.Add(CurentContact);
                        }
                        else
                        {
                            int index = Contacts.IndexOf(CurentContact);
                            CurentContact = CopyContact(EditedContact);
                            Contacts[index] = CopyContact(CurentContact);
                            CurentContact = Contacts[index];
                        }
                        IsEditing = false;
                        IsVisible = false;
                        ContactSerializer.SaveToFile(Contacts);
                    }, 
                    (obj) => (CurentContact!=null)));
            }
        }

        /// <summary>
        /// Создает экземпляр <see cref="MainVM"/>.
        /// </summary>
        public MainVM()
        {
            EditedContact = new Contact();
            CurentContact = new Contact();
            _contacts = ContactSerializer.LoadFromFile();
            if (Contacts.Count != 0)
            {
                CurentContact= _contacts[0];
            }
            IsEditing = false;
            IsReadOnly = true;
            IsVisible = false;
        }

        /// <summary>
        /// Возвращает и задает флаг для доступа к текстбоксам.
        /// </summary>
        public bool IsReadOnly
        {
            get
            {
                return _isReadOnly;
            }
            set
            {
                if (_isReadOnly != value)
                {
                    _isReadOnly = value;
                    OnPropertyChanged();
                }
            }
        }

        /// <summary>
        /// Возвращает и задает флаг для пометки редактирования объекта.
        /// </summary>
        public bool IsEditing
        {
            get
            {
                return _isEditing;
            }
            set
            {
                if (_isEditing != value)
                {
                    _isEditing = value;
                    OnPropertyChanged();
                }
            }
        }

        /// <summary>
        /// Возвращает и задает значение свойства видимости кнопки Apply.
        /// </summary>
        public bool IsVisible
        {
            get
            {
                return _isVisible;
            }
            set
            {
                if (_isVisible != value)
                {
                    _isVisible = value;
                    OnPropertyChanged();
                }
            }
        }

        /// <summary>
        /// Коллекция объектов типа <see cref="Contact"/>.
        /// </summary>
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

        /// <summary>
        /// Возвращает и задает копию редактированного контакта.
        /// </summary>
        public Contact EditedContact 
        {
            get 
            { 
                return _editedContact; 
            }
            set
            {
                if(_editedContact != value)
                {
                    _editedContact = value;
                }
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Возвращает и задает выбранный контакт.
        /// </summary>
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
                    IsEditing = false;
                    IsReadOnly = true;
                    IsVisible = false;
                    _сurentContact = value;
                    EditedContact = CopyContact(CurentContact);
                }
                OnPropertyChanged();
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
        /// Метод для копирования объектов типа <see cref="Contact"/>.
        /// </summary>
        /// <param name="contact">Контак в который копируются данные.</param>
        /// <param name="copiedContact">Копируемый контакт.</param>
        private Contact CopyContact(Contact copiedContact)
        {
            var contact = new Contact();
            if (copiedContact != null)
            {
                contact.Name = copiedContact.Name;
                contact.Email = copiedContact.Email;
                contact.PhoneNumber = copiedContact.PhoneNumber;
            }
            return contact;
        }
    }
}


