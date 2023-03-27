using FYP.ViewModels;
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
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            
            InitializeComponent();
        }

        private async void PopularButton_Clicked(object sender, EventArgs e)
        {
            //Navigates to the popular games page
            await Navigation.PushAsync(new PopularGames());
        }

        private async void BestPrice_Clicked(object sender, EventArgs e)
        {
            //Navigates to the best price page
            await Navigation.PushAsync(new BestPrice());
        }

        private async void UpComing_Clicked(object sender, EventArgs e)
        {
            //Navigates to the upcoming page
            await Navigation.PushAsync(new UpComing());
        }

        private async void Trending_Clicked(object sender, EventArgs e)
        {
            //Navigates to the trending page
            await Navigation.PushAsync(new Trending());
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            //Navigates to the review page
            await Navigation.PushAsync(new ReviewPage());

        }
    }
}