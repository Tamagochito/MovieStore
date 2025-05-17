using MovieStore.Models.DTO;

namespace MovieStore.BL.Interfaces
{
    public interface IMovieService
      {
        List<Movie> GetAll();

        Movie? GetById(string id);

        Task Add(Movie movie);

        void AddActorToMovie(string movieId, string actor);
    }
}
