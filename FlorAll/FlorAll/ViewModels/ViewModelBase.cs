using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace FlorAll.ViewModels
{
    public abstract class ViewModelBase : NotifyBase
    {
        private bool isLoading = false;
        private bool isNotLoading = true;
        private readonly Services.IMessageService _messageService;
        private readonly Services.INavigationService _navigationService;

        public bool IsLoading
        {
            get { return isLoading; }
            set
            {
                isNotLoading = !value;
                isLoading = value;
                this.Notify("IsNotLoading");
                this.Notify("IsLoading");
            }
        }

        public bool IsNotLoading
        {
            get { return isNotLoading; }
            set
            {
                isNotLoading = value;
                isLoading = !value;
                this.Notify("IsNotLoading");
                this.Notify("IsLoading");
            }
        }

        public ViewModelBase()
        {
            this._messageService = DependencyService.Get<Services.IMessageService>();
            this._navigationService = DependencyService.Get<Services.INavigationService>();


        }

        public Services.INavigationService NavigationService()
        {
            return _navigationService;
        }

        public Services.IMessageService MessageService()
        {
            return _messageService;
        }

    }
}
