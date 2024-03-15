using System.ComponentModel;
using System.Runtime.CompilerServices;
using View.Model;

namespace View.ViewModel
{
    internal class MainVM : INotifyPropertyChanged
    {
        private Contact _contact;

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

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}

 
