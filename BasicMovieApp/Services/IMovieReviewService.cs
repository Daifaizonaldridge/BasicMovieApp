using BasicMovieApp.Models;

namespace BasicMovieApp.Services
{
    public interface IMovieReviewService
    {
        List<MovieModel> GetMovies ();
        MovieModel? GetMovieById(int id);
    }
}
