using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace FYP.ViewModels
{

    public class NewReleasesViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<NewGames> NewGames;

        public ObservableCollection<NewGames> Games
        {
            get { return NewGames; }//!< Gets the data of the collection
            set { NewGames = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Games")); }//!<Updates the collection with the new data
        }

        public NewReleasesViewModel() 
        {
            Games = new ObservableCollection<NewGames>();//!< Creates a new instance of the observable collection
            AddData();//!< Adds the data of the new game
        }
        private void AddData()
        {
            Games.Add(new NewGames
            {
                Id = 0,
                GameTitle = "The Elder Scrolls Online",
                Rating = 4.9,
                ImageSource= "https://assets-prd.ignimgs.com/2022/01/05/elderscrollsonline-1641413357689.jpg",
                Price = "Free"
            });
            Games.Add(new NewGames
            {
                Id = 1,
                GameTitle = "World Of Warcraft",
                Rating = 4.9,
                ImageSource = "https://assets-prd.ignimgs.com/2021/12/10/wow-1639126324635.jpg",
                Price = "Free"
            });
            Games.Add(new NewGames
            {
                Id = 2,
                GameTitle = "Star Wars:The Old Republic",
                Rating = 4,
                ImageSource = "https://assets-prd.ignimgs.com/2022/01/27/swotor-sq1-1643302998212.jpg",
                Price = "Free"
            });
        }
    }
}
