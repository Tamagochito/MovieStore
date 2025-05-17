using MovieStore.Models.DTO;

namespace MovieStore.DL.Interfaces
{
    public interface IMovieRepository
    {
        Task<List<Movie>> GetAll();

        Task<Movie?> GetById(string id);

        Task Add(Movie movie);

        Task Update(Movie movie);
    }
}
