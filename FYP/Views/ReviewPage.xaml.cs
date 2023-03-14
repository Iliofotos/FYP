using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FYP.Services;



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
            int id;
            if (Picker.Equals("The Elder Scrolls Online")) { id = 1; }
            else if (Picker.Equals("World Of Warcraft")) { id = 2; }
            else { id = 3; }
            DoneButton.IsEnabled = true;
            SavedButton.IsEnabled = false;
            MySQLDatabase db = new MySQLDatabase();
            db.MyDatabase();
            string q1 = Question1.ToString();
            string q2 = Question2.ToString();
            string q3 = Question3.ToString();
            string q4 = Question4.ToString();
            string q5 = Question5.ToString();
            string q6 = Question6.ToString();
            string q7 = Question7.ToString();
            string q8 = Question8.ToString();
            db.InsertData(id, q1, q8, q4, q3, q5, q6, q7, q2);
           
        }

        private async void DoneButton_Pressed(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}
