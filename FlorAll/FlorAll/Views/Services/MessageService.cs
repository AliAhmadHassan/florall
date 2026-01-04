using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FlorAll.Views.Services
{
    public class MessageService : ViewModels.Services.IMessageService
    {
        public async Task ShowAsync(string message)
        {
            await FlorAll.App.Current.MainPage.DisplayAlert("Atenção!", message, "OK");
        }
    }
}
