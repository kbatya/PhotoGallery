using System.Text.RegularExpressions;
using PhotoGallery.Models;
namespace PhotoGallery
{

    public partial class RegistrationPage : ContentPage
    {
        public User User { get; set; }

        public RegistrationPage()
        {
            InitializeComponent();
            User = new User();
            BindingContext = User;
        }

        private void OnRegisterClicked(object sender, EventArgs e)
        {
            ErrorLabel.Text = "";
            if (!ValidateRequiredFields())
            {
                ErrorLabel.Text = "All fields are required. Please fill in all the information.";
                return;
            }

            if (!ValidateUsername())
            {
                ErrorLabel.Text = "Username cannot start with a digit and must not contain spaces.";
                return;
            }

            if (!ValidatePassword())
            {
                ErrorLabel.Text = "Password must contain at least one uppercase letter and one number.";
                return;
            }

            if (!ValidateAge())
            {
                ErrorLabel.Text = "You must be over 18 to register.";
                return;
            }

            // If all validations pass, proceed with registration
            // Add your registration logic here
        }
        private bool ValidateRequiredFields()
        {
            return !string.IsNullOrWhiteSpace(User.Name) &&
                   !string.IsNullOrWhiteSpace(User.Username) &&
                   !string.IsNullOrWhiteSpace(User.Email) &&
                   !string.IsNullOrWhiteSpace(User.Phone) &&
                   !string.IsNullOrWhiteSpace(User.Password) &&
                   User.DateOfBirth != default;
        }
        private bool ValidateUsername()
        {
            return !char.IsDigit(User.Username[0]) && !User.Username.Contains(" ");
        }

        private bool ValidatePassword()
        {
            return Regex.IsMatch(User.Password, @"^(?=.*[A-Z])(?=.*\d).+$");
        }

        private bool ValidateAge()
        {
            return User.Age > 18;
        }
    }
}