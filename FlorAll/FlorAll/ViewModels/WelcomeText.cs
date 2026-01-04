using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace FlorAll.ViewModels
{
    public class WelcomeText : ViewModelBase
    {
        public ICommand ShareCommand { get; set; }

        public ICommand GotoNextStepCommand { get; set; }

        private readonly Services.IMessageService _messageService;
        private readonly Services.INavigationService _navigationService;

        public WelcomeText()
        {
            this._messageService = DependencyService.Get<Services.IMessageService>();
            this._navigationService = DependencyService.Get<Services.INavigationService>();

            this.ShareCommand = new Command(this.Share);
            this.GotoNextStepCommand = new Command(this.GotoNextStep);
        }

        public void Share()
        {

        }

        public void GotoNextStep()
        {

        }
    }
}
