using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FlorAll.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
            this.BindingContext = new FlorAll.ViewModels.Login();

            Entry txtEmail = new Entry();
            txtEmail.Keyboard = Keyboard.Email;
            txtEmail.Placeholder = "email@server.com";
            txtEmail.HorizontalOptions = new LayoutOptions { Expands = true, Alignment = LayoutAlignment.Fill };

            Entry txtPassword = new Entry();
            txtPassword.Keyboard = Keyboard.Email;
            txtPassword.Placeholder = "senha";
            txtEmail.HorizontalOptions = new LayoutOptions { Expands = true, Alignment = LayoutAlignment.Fill };

            layout_entry.Children.Add(txtEmail);
            layout_entry.Children.Add(new StackLayout { HeightRequest = 2 });
            layout_entry.Children.Add(txtPassword);
        }

        public void BackPage()
        {
            App.Current.MainPage = new FlorAll.Views.SelectLogin();
        }
    }
}