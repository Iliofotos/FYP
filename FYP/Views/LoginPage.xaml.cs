using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FYP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Login_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            //Checks if the check box is ticked
            if (e.Value)
            {
                LoginButton.IsEnabled = true;
            }
            else
            {
                LoginButton.IsEnabled = false;
            }
          
        }

        private async void LoginButton_Clicked(object sender, EventArgs e)
        {
            //Navigates to the main page
            await Navigation.PushAsync(new MainPage());
        }
    }
}