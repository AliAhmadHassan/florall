using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FlorAll.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreateUser : ContentPage
    {
        public CreateUser()
        {
            InitializeComponent();
            this.BindingContext = new FlorAll.ViewModels.CreateUser();

            FlorAll.MyEntry txtName = new MyEntry();
            txtName.Keyboard = Keyboard.Email;
            txtName.Placeholder = "Nome";
            txtName.HorizontalOptions = new LayoutOptions { Expands = true, Alignment = LayoutAlignment.Fill };
            layout_form.Children.Add(txtName);

            FlorAll.MyEntry txtEmail = new MyEntry();
            txtEmail.Keyboard = Keyboard.Email;
            txtEmail.Placeholder = "Email";
            txtEmail.HorizontalOptions = new LayoutOptions { Expands = true, Alignment = LayoutAlignment.Fill };
            layout_form.Children.Add(txtEmail);

            FlorAll.MyEntry txtUser = new MyEntry();
            txtUser.Keyboard = Keyboard.Email;
            txtUser.Placeholder = "Usuário";
            txtUser.HorizontalOptions = new LayoutOptions { Expands = true, Alignment = LayoutAlignment.Fill };
            layout_form.Children.Add(txtUser);

            FlorAll.MyEntry txtPassword = new MyEntry();
            txtPassword.Keyboard = Keyboard.Email;
            txtPassword.Placeholder = "Senha";
            txtPassword.HorizontalOptions = new LayoutOptions { Expands = true, Alignment = LayoutAlignment.Fill };
            layout_form.Children.Add(txtPassword);

            Dictionary<string, Color> nameToColor = new Dictionary<string, Color>
        {
            { "Aqua", Color.Aqua }, { "Black", Color.Black },
            { "Blue", Color.Blue }, { "Fucshia", Color.Blue },
            { "Gray", Color.Gray }, { "Green", Color.Green },
            { "Lime", Color.Lime }, { "Maroon", Color.Maroon },
            { "Navy", Color.Navy }, { "Olive", Color.Olive },
            { "Purple", Color.Purple }, { "Red", Color.Red },
            { "Silver", Color.Silver }, { "Teal", Color.Teal },
            { "White", Color.White }, { "Yellow", Color.Yellow }
        };

            MyPicker lstCity = new MyPicker();
            lstCity.Title = "Cidade";
            lstCity.HorizontalOptions = new LayoutOptions { Expands = true, Alignment = LayoutAlignment.Fill };
            foreach (string colorName in nameToColor.Keys)
                lstCity.Items.Add(colorName);

            layout_form.Children.Add(lstCity);

            FlorAll.MyEntry txtPhone = new MyEntry();
            txtPhone.Keyboard = Keyboard.Email;
            txtPhone.Placeholder = "Telefone";
            txtPhone.HorizontalOptions = new LayoutOptions { Expands = true, Alignment = LayoutAlignment.Fill };
            layout_form.Children.Add(txtPhone);

        }
    }

   
}