using MovieStore.Models.DTO;

namespace MovieStore.DL.Interfaces
{
    public interface IActorRepository
    {
        Task<List<Actor>> GetAll();

        Task<List<Actor>> GetAll(List<string> ids);

        Task<Actor?> GetById(string id);

        Task Add(Actor? actor);

        void Update(Actor movie);
    }
}
