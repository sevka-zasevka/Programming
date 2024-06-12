using System.Collections.ObjectModel;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Model;
using Model.Services;

namespace ViewModel
{
    /// <summary>
    /// Класс viewModel, соединяющий уровни View и Model.
    /// </summary>
    public class MainVM : ObservableObject
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
        public ICommand AddCommand { get; }

        /// <summary>
        /// Команда удаления объекта.
        /// </summary>
        public ICommand RemoveCommand { get; }

        /// <summary>
        /// Команда редактирования объекта.
        /// </summary>
        public ICommand EditCommand { get; }

        /// <summary>
        /// Команда сохранения созданного или отредактирононового объекта.
        /// </summary>
        public ICommand ApplyCommand { get; }

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
        
        private void AddContact()
        {
            if (IsReadOnly != false)
            {
                CurentContact = new Contact();
                IsReadOnly = false;
                IsVisible = true;
            }
        }

        /// <summary>
        /// Удаляет выбранный объект.
        /// Сохраняет в файл.
        /// </summary>
        public void RemoveContact()
        {
            if (Contacts.Count > 0 && CurentContact != null &&
                          Contacts.IndexOf(CurentContact) != -1 &&
                          IsReadOnly != false)
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
            }

        }

        /// <summary>
        /// Открывает доступ к редактированию выбранного объекта.
        /// </summary>
        public void EditContact()
        {
            if (CurentContact != null && (IsReadOnly != false))
            {
                IsEditing = true;
                IsReadOnly = false;
                IsVisible = true;
            }
        }

        /// <summary>
        /// Добавляет созданный объект или созраняет изменения.
        /// Сохраняет в файл.
        /// </summary>
        public void ApplyContact()
        {
            if ((CurentContact != null))
            {
                IsReadOnly = true;
                if (IsEditing != true)
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
            AddCommand = new RelayCommand(AddContact);
            EditCommand = new RelayCommand(EditContact);
            RemoveCommand = new RelayCommand(RemoveContact);
            ApplyCommand = new RelayCommand(ApplyContact);
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


