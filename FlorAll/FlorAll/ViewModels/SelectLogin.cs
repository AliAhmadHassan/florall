using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace FlorAll.ViewModels
{
    public class SelectLogin : ViewModelBase
    {
        public ICommand CreateUserCommand { get; set; }

        public ICommand LoginCommand { get; set; }

        public ICommand GetPasswordCommand { get; set; }

        public ICommand FacebookUserCommand { get; set; }

        private readonly Services.IMessageService _messageService;
        private readonly Services.INavigationService _navigationService;

        public SelectLogin()
        {
            this._messageService = DependencyService.Get<Services.IMessageService>();
            this._navigationService = DependencyService.Get<Services.INavigationService>();

            this.CreateUserCommand = new Command(this.CreateUser);
            this.LoginCommand = new Command(this.Login);
            this.GetPasswordCommand = new Command(this.GetPassword);
            this.FacebookUserCommand = new Command(this.FacebookUser);
        }

        private void CreateUser()
        {
            this._navigationService.NavigationToCreateUser();
        }

        private void Login()
        {
            this._navigationService.NavigationToLogin();
        }

        private void GetPassword()
        {

        }

        private void FacebookUser()
        {

        }
    }
}
