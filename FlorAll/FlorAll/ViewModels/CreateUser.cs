using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace FlorAll.ViewModels
{
    public class CreateUser : ViewModelBase
    {
        public ICommand CreateUserCommand { get; set; }

        public ICommand AceptCommand { get; set; }

        private readonly Services.IMessageService _messageService;
        private readonly Services.INavigationService _navigationService;

        public CreateUser()
        {
           
            this._messageService = DependencyService.Get<Services.IMessageService>();
            this._navigationService = DependencyService.Get<Services.INavigationService>();

            this.CreateUserCommand = new Command(this.AddUser);
            this.AceptCommand = new Command(this.Acept);

           

        }

        public void AddUser()
        {
            //App.Current.MainPage = new FlorAll.Views.WelcomeText();
        }

        public void Acept()
        {
            
        }
    }
}
