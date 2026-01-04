using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FlorAll.Views.Services
{
    public class NavigationService : ViewModels.Services.INavigationService
    {
        public void NavigationToCreateUser()
        {
            FlorAll.App.Current.MainPage = new Views.CreateUser();
        }

        public void NavigationToFeed()
        {
           FlorAll.App.Current.MainPage = new Views.Feeds();
        }

        public void NavigationToLogin()
        {
           FlorAll.App.Current.MainPage = new Views.Login();
        }

        public async Task NavigationToSelectLogin()
        {
           // await FlorAll.App.Current.MainPage.Navigation.PushAsync(new Views.SelectLogin());
        }

        public async Task NavigationToWelcomeText()
        {
           // await FlorAll.App.Current.MainPage.Navigation.PushAsync(new Views.WelcomeText());
        }
    }
}
