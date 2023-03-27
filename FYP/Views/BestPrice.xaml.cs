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
    public partial class BestPrice : ContentPage
    {
        public BestPrice()
        {
            InitializeComponent();
        }

        async private void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            //Navigates to the review page
            await Navigation.PushAsync(new ReviewPage());
        }
    }
    
}