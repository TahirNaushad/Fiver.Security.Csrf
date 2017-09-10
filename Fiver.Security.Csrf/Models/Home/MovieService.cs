using System.Collections.Generic;
using System.Linq;

namespace Fiver.Security.Csrf.Models.Home
{
    public class MovieService : IMovieService
    {
        private readonly List<Movie> movies;

        public MovieService()
        {
            this.movies = new List<Movie>
            {
                new Movie { Title = "Never Say Never Again" },
                new Movie { Title = "Diamonds Are Forever " },
                new Movie { Title = "You Only Live Twice " }
            };
        }

        public List<Movie> GetMovies()
        {
            return this.movies.ToList();
        }
        
        public void AddMovie(Movie item)
        {
            this.movies.Add(item);
        }
    }
}
