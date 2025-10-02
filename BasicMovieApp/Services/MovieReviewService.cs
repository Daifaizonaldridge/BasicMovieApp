using BasicMovieApp.Models;

namespace BasicMovieApp.Services
{
    public class MovieReviewService : IMovieReviewService
    {
        private static readonly List<MovieModel> Movies = new List<MovieModel>
            {
                new MovieModel
                {
                    Id = 1,
                    Title = "Highlander",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    ImageUrl = "/images/movies/Highlander.png",
                    Review = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam elit neque, pretium quis rhoncus a, molestie id est. Nulla congue tortor hendrerit pulvinar convallis."
                },
                new MovieModel
                {
                    Id = 2,
                    Title = "Godfather",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    ImageUrl = "/images/movies/Godfather.png",
                    Review = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam elit neque, pretium quis rhoncus a, molestie id est. Nulla congue tortor hendrerit pulvinar convallis."
                },
                new MovieModel
                {
                    Id = 3,
                    Title = "Last of the Mohicans",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    ImageUrl = "/images/movies/LastOfTheMohicans.png",
                    Review = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam elit neque, pretium quis rhoncus a, molestie id est. Nulla congue tortor hendrerit pulvinar convallis."
                },
                 new MovieModel
                {
                    Id = 4,
                    Title = "Police Academy",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    ImageUrl = "/images/movies/PoliceAcademy6.png",
                    Review = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam elit neque, pretium quis rhoncus a, molestie id est. Nulla congue tortor hendrerit pulvinar convallis."
                },
                 new MovieModel
                {
                    Id = 5,
                    Title = "Rear Window",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    ImageUrl = "/images/movies/RearWindow.png",
                    Review = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam elit neque, pretium quis rhoncus a, molestie id est. Nulla congue tortor hendrerit pulvinar convallis."
                },
                 new MovieModel
                {
                    Id = 6,
                    Title = "Road House",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    ImageUrl = "/images/movies/RoadHouse.png",
                    Review = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam elit neque, pretium quis rhoncus a, molestie id est. Nulla congue tortor hendrerit pulvinar convallis."
                },
            };
        
        public MovieModel? GetMovieById(int id)
        {
            return Movies.SingleOrDefault(m => m.Id == id);
        }

        public List<MovieModel>? GetMovies()
        {
            return Movies;
        }
    }
}
