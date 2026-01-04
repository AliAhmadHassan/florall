using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FlorAll.ViewModels.Services
{
    public interface INavigationService
    {
        void NavigationToLogin();
        void NavigationToFeed();

        void NavigationToCreateUser();
        Task NavigationToSelectLogin();
        Task NavigationToWelcomeText();
    }
}
