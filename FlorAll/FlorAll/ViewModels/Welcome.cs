using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace FlorAll.ViewModels
{
    public class Welcome : ViewModelBase
    {
        public ICommand RedirectCommand { get; set; }

        private readonly Services.IMessageService _messageService;
        private readonly Services.INavigationService _navigationService;

        public Welcome()
        {
            this._messageService = DependencyService.Get<Services.IMessageService>();
            this._navigationService = DependencyService.Get<Services.INavigationService>();

            this.RedirectCommand = new Command(this.Redirect);
        }

        public void Redirect()
        {

            this._navigationService.NavigationToSelectLogin();

        }
    }
}
