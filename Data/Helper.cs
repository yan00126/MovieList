namespace MovieList;

public class Helper
{
  public static List<Movie> GetMovies () 
  {
    List<Movie> movies = new List<Movie> 
    {
      new Movie { Id = 1, Title = "The Shawshank Redemption", Genre = "Drama", Director = "Frank Darabont", Year = 1994 },
      new Movie { Id = 2, Title = "The Godfather", Genre = "Crime", Director = "Francis Ford Coppola", Year = 1972 },
      new Movie { Id = 3, Title = "The Dark Knight", Genre = "Action", Director = "Christopher Nolan", Year = 2008 },
      new Movie { Id = 4, Title = "The Lord of the Rings: The Return of the King", Genre = "Adventure", Director = "Peter Jackson", Year = 2003 },
      new Movie { Id = 5, Title = "Pulp Fiction", Genre = "Crime", Director = "Quentin Tarantino", Year = 1994 },
      new Movie { Id = 6, Title = "Forrest Gump", Genre = "Drama", Director = "Robert Zemeckis", Year = 1994 },
      new Movie { Id = 7, Title = "Inception", Genre = "Action", Director = "Christopher Nolan", Year = 2010 },
      new Movie { Id = 8, Title = "The Matrix", Genre = "Action", Director = "Lana Wachowski, Lilly Wachowski", Year = 1999 },
      new Movie { Id = 9, Title = "Interstellar", Genre = "Adventure", Director = "Christopher Nolan", Year = 2014 },
      new Movie { Id = 10, Title = "The Lord of the Rings: The Fellowship of the Ring", Genre = "Adventure", Director = "Peter Jackson", Year = 2001 },
      new Movie { Id = 11, Title = "The Lord of the Rings: The Two Towers", Genre = "Adventure", Director = "Peter Jackson", Year = 2002 },
      new Movie { Id = 12, Title = "The Godfather: Part II", Genre = "Crime", Director = "Francis Ford Coppola", Year = 1974 },
      new Movie { Id = 13, Title = "Fight Club", Genre = "Drama", Director = "David Fincher", Year = 1999 },
      new Movie { Id = 14, Title = "The Avengers", Genre = "Action", Director = "Joss Whedon", Year = 2012 },
      new Movie { Id = 15, Title = "The Silence of the Lambs", Genre = "Thriller", Director = "Jonathan Demme", Year = 1991 },
      new Movie { Id = 16, Title = "The Departed", Genre = "Crime", Director = "Martin Scorsese", Year = 2006 },
      new Movie { Id = 17, Title = "The Godfather: Part III", Genre = "Crime", Director = "Francis Ford Coppola", Year = 1990 },
      new Movie { Id = 18, Title = "The Dark Knight Rises", Genre = "Action", Director = "Christopher Nolan", Year = 2012 },
      new Movie { Id = 19, Title = "The Lion King", Genre = "Animation", Director = "Roger Allers, Rob Minkoff", Year = 1994 },
      new Movie { Id = 20, Title = "The Prestige", Genre = "Drama", Director = "Christopher Nolan", Year = 2006 },
      new Movie { Id = 21, Title = "The Green Mile", Genre = "Drama", Director = "Frank Darabont", Year = 1999 },
      new Movie { Id = 22, Title = "The Social Network", Genre = "Biography", Director = "David Fincher", Year = 2010 },
      new Movie { Id = 23, Title = "The Pursuit of Happyness", Genre = "Biography", Director = "Gabriele Muccino", Year = 2006 },
      new Movie { Id = 24, Title = "The Incredibles", Genre = "Animation", Director = "Brad Bird", Year = 2004 },
      new Movie { Id = 25, Title = "The Hobbit: An Unexpected Journey", Genre = "Adventure", Director = "Peter Jackson", Year = 2012 },
    };

    return movies;
  }
}
