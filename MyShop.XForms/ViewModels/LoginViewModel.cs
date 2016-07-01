using MyShop.XForms.Core;
using MyShop.XForms.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;


namespace MyShop.XForms.ViewModels
{
    class LoginViewModel : BaseViewModel
    {   
        private UserService _userService;
        private INavigation navigation;

        // Username
        public const string UsernamePropertyName = "Username";
        private string _username = string.Empty;
        public string Username {
            get { return _username; } set { _username = value; }
        }

        // Password
        public const string PasswordPropertyName = "Password";
        private string _password = string.Empty;
        public string Password {
            get { return _password; }  set { _password = value; OnPropertyChanged(PasswordPropertyName); }
        }

        // Logincommand
        public const string LoginCommandPropertyName = "LoginCommand";
        private Command _loginCommand;
        public Command LoginCommand {
            get { return _loginCommand; }
        }
        
        ///////////////

        public LoginViewModel(INavigation navigation)
        {
            this.navigation = navigation;

            this.Title = "Login";
            this.Icon = "";

            _username = "Kenny1980";
            _password = "BlaBlaBla";

            _userService = new UserService(); //(UserService)UserService.getInstance();

            _loginCommand = new Command(async () => await ExecuteLoginCommand());
        }

        protected async Task ExecuteLoginCommand()
        {
            await navigation.PopModalAsync();
            //Password = Username;
            //_username = "Changed";
            //OnPropertyChanged(UsernamePropertyName);
        }

         

    }
}
