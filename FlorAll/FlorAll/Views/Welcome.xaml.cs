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
    public partial class Welcome : ContentPage
    {
        public Welcome()
        {
            InitializeComponent();
            this.BindingContext = new ViewModels.Welcome();
        }

        public void Avancar()
        {
            App.Current.MainPage = new FlorAll.Views.SelectLogin();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            CarregarPais();
        }

        public async void CarregarPais()
        {
            try
            {
                var lst = await new BLL.ServiceCountrie().GetAll();
                Avancar();
            }
            catch (Exception ex)
            {
                
            }
        }
    }
}