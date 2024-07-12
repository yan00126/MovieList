namespace MovieList;

public class Movie
{
  public int Id { get; set; }
  public string Title { get; set; } = "";
  public string Genre { get; set; } = "";
  public string Director { get; set; } = "";
  public int Year { get; set; }
  public bool Watched { get; set; }
}
