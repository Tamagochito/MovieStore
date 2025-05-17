using MovieStore.Models.Views;

namespace MovieStore.BL.Interfaces
{
    public interface IMovieBlService
     {
        Task<List<MovieFullDetailsResponse>> GetAllMovies();
    }
}
