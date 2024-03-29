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
        private Contact _contact;

        private RelayCommand saveCommand;

        private RelayCommand loadCommand;

        public RelayCommand SaveCommand
        {
            get
            {
                return saveCommand ??
                  (saveCommand = new RelayCommand(obj => ContactSerializer.SaveToFile(_contact)));
            }
        }

        public RelayCommand LoadCommand
        {
            get
            {
                return loadCommand ??
                    (loadCommand = new RelayCommand(obj =>
                    {
                        var contact = ContactSerializer.LoadFromFile();
                        Name = contact.Name;
                        PhoneNumber = contact.PhoneNumber;
                        Email = contact.Email;
                    }));
            }
        }

        public MainVM()
        {
            _contact = new Contact();
        }

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

        private void LoadContact(Contact contact)
        {
            if (contact != null)
            {
                Name = contact.Name;
                Email = contact.Email;
                PhoneNumber = contact.PhoneNumber;
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}

 
