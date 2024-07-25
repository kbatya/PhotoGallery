using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PhotoGallery.Models
{
    public class User : INotifyPropertyChanged
    {
        private string name;
        private string username;
        private string email;
        private string phone;
        private string password;
        private DateTime dateOfBirth;

        public string Name
        {
            get => name;
            set => SetProperty(ref name, value);
        }

        public string Username
        {
            get => username;
            set => SetProperty(ref username, value);
        }

        public string Email
        {
            get => email;
            set => SetProperty(ref email, value);
        }

        public string Phone
        {
            get => phone;
            set => SetProperty(ref phone, value);
        }

        public string Password
        {
            get => password;
            set => SetProperty(ref password, value);
        }

        public DateTime DateOfBirth
        {
            get => dateOfBirth;
            set
            {
                if (SetProperty(ref dateOfBirth, value))
                    OnPropertyChanged(nameof(Age));
            }
        }

        public int Age => DateTime.Now.Year - DateOfBirth.Year - (DateTime.Now.DayOfYear < DateOfBirth.DayOfYear ? 1 : 0);

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (Equals(storage, value))
                return false;

            storage = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }

}
