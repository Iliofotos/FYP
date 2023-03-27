namespace FYP.ViewModels
{
    public class NewGames
    {
        //Contains all the game properties
        public int Id { get; set; }
        public string GameTitle { get; set; }
        public double Rating { get; set; }
        public string ImageSource { set; get; }
        public string Price { get; set; }
    }
}