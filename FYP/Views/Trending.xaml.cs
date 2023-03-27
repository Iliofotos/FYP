using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FYP.ViewModels;

namespace FYP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Trending : ContentPage
    {
        public Trending()
        {
            InitializeComponent();
            
        }
        async private void OnItemTabbed(object sender, ItemTappedEventArgs e)
        {
            //Navigates to a different page
            await Navigation.PushAsync(new ReviewPage());

        }
    }
}