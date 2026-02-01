🎮 Video Game Rating App
A cross-platform mobile application for discovering and rating video games, built with Xamarin Forms and C#.
Features

Browse Games - Carousel view of new releases with game artwork
Multiple Categories - Trending, Popular, Best Price, and Upcoming games
Review System - Rate games across 8 different criteria
Local Storage - Reviews saved to device using file-based persistence
Cross-Platform - Single codebase for iOS and Android

Screenshots
Home ScreenCategoriesReview PageNew releases carouselTrending, Popular, Best Price, Upcoming8-question rating form
Tech Stack

Framework: Xamarin Forms
Language: C#
Architecture: MVVM (Model-View-ViewModel)
UI Components: CarouselView, Shell Navigation, Data Binding
Data: ObservableCollection with INotifyPropertyChanged
Storage: Local file system via DependencyService

Project Structure
FYP/
├── Views/           # XAML pages (MainPage, ReviewPage, etc.)
├── ViewModels/      # Data binding logic (NewReleasesViewModel)
├── Services/        # File storage and data services
FYP.Android/         # Android-specific implementation
FYP.iOS/             # iOS-specific implementation
Architecture
The app follows the MVVM pattern:

Models (NewGames.cs) - Data structures for game information
ViewModels (NewReleasesViewModel.cs) - Business logic with property change notifications
Views (.xaml files) - UI with data binding to ViewModels

Getting Started
Prerequisites

Visual Studio 2019+ with Xamarin workload
Android SDK or iOS simulator

Run the App

Clone the repository
Open FYP.sln in Visual Studio
Select Android or iOS as startup project
Build and run

Final Year Project
This application was developed as my Final Year Project for BSc Computer Games Programming at De Montfort University (2023).
Author
Iliofotos Iliofotou

GitHub: @Iliofotos

Check out my projects:

- 🏦 [Credit Card Default Prediction](https://github.com/Iliofotos/CreditCardDefaultPrediction) - ML classification with 5 algorithms on 30k records
- 🏦 [IMDB Sentiment Analysis](https://github.com/Iliofotos/IMDBSentimentAnalysis/tree/main) - ML Sentiment Analysis using Multinomial Naive Bayes

License
This project is available for educational purposes.
