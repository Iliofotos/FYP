using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FYP.Services;
using FYP.ViewModels;

namespace FYP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReviewPage : ContentPage
    {
        

        public ReviewPage()
        {
            InitializeComponent();

        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Disables all the questions and buttons if a game has not been picked
            if (!e.Equals(Title))
            {
                Question1.IsEnabled = true;
                Question2.IsEnabled = true;
                Question3.IsEnabled = true;
                Question4.IsEnabled = true;
                Question5.IsEnabled = true;
                Question6.IsEnabled = true;
                Question7.IsEnabled = true;
                Question8.IsEnabled = true;
                SavedButton.IsEnabled = true;
            }
            
        }
        private void Button_Pressed(object sender, EventArgs e)
        {
            int reviewId = 0;
            reviewId = reviewId + 1;
            string id = "0";
            var selectedItem = Picker.SelectedItem as NewGames;
            //Checks which game did the user pick to assign the corresponding id
            if (selectedItem != null)
            {
                if (selectedItem.GameTitle == "The Elder Scrolls Online") { id = "1"; }
                else if (selectedItem.GameTitle == "World Of Warcraft") { id = "2"; }
                else if (selectedItem.GameTitle == "Star Wars:The Old Republic") { id = "3"; }
                else if (selectedItem.GameTitle == "Minecraft") { id = "4"; }
                else if (selectedItem.GameTitle == "Fallout 76") { id = "5"; }
            }
            DoneButton.IsEnabled = true;
            SavedButton.IsEnabled = false;
            //Turns all the user input to text and stores it in a string
            string q1 = Question1.Text;
            string q2 = Question2.Text;
            string q3 = Question3.Text;
            string q4 = Question4.Text;
            string q5 = Question5.Text;
            string q6 = Question6.Text;
            string q7 = Question7.Text;
            string q8 = Question8.Text;

            //Populates the file
            DependencyService.Get<IFileService>().CreateFile(reviewId.ToString());
            DependencyService.Get<IFileService>().CreateFile(id);
            DependencyService.Get<IFileService>().CreateFile(q1);
            DependencyService.Get<IFileService>().CreateFile(q2);
            DependencyService.Get<IFileService>().CreateFile(q3);
            DependencyService.Get<IFileService>().CreateFile(q4);
            DependencyService.Get<IFileService>().CreateFile(q5);
            DependencyService.Get<IFileService>().CreateFile(q6);
            DependencyService.Get<IFileService>().CreateFile(q7);
            DependencyService.Get<IFileService>().CreateFile(q8);
        }

        private async void DoneButton_Pressed(object sender, EventArgs e)
        {
            //Navigates to the next page
            await Navigation.PushAsync(new MainPage());
            //Clears the file after the user is done
            //DependencyService.Get<IFileService>().ClearFile();
        }

        private void OnEditorTextedChanged(object sender, TextChangedEventArgs e)
        {
            double result;
            if (!double.TryParse(e.NewTextValue, out result))
            {
                // Input is not a valid number, display error message to user
                DisplayAlert("Error", "Please enter a valid number.", "OK");
            }
            else
            {
            }
        }
    }
}
