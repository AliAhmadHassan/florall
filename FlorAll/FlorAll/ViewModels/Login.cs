using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace FlorAll.ViewModels
{
    public class Login : ViewModelBase
    {
        private string email = "Admin";
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                this.Notify("Email");
            }
        }

        private string password = "admin";
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                this.Notify("Password");
            }
        }

        public ICommand ValidateCommand { get; set; }

        private readonly Services.IMessageService _messageService;
        private readonly Services.INavigationService _navigationService;

        public Login()
        {
            this._messageService = DependencyService.Get<Services.IMessageService>();
            this._navigationService = DependencyService.Get<Services.INavigationService>();
            this.ValidateCommand = new Command(this.Validate);

           
        }

        public void Validate()
        {
            IsLoading = true;
            
        }
        
    }
}
