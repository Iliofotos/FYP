using SQLite;

public class MyTable
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public int GameId { get; set; }
    public string PreOrder { get; set; }
    public string Rating { get; set; }
    public string Standards { set; get; }
    public string OverPriced { get; set; }
    public string AgeRating { get; set; }
    public string Gameplay { get; set; }
    public string Recommend { get; set; }
    public string Impact { get; set; }
}


