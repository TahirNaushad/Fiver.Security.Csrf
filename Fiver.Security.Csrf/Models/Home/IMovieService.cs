using System.Collections.Generic;

namespace Fiver.Security.Csrf.Models.Home
{
    public interface IMovieService
    {
        List<Movie> GetMovies();
        void AddMovie(Movie item);
    }
}
