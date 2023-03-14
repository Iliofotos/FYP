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
    public partial class PopularGames : ContentPage
    {
        public PopularGames()
        {
            InitializeComponent();
        }

        async private void OnItemTabbed(object sender, ItemTappedEventArgs e)
        {
            await Navigation.PushAsync(new ReviewPage());

        }
    }
}