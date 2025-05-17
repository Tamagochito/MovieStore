using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MovieStore.DL.Interfaces;
using MovieStore.Models.Configurations;
using MovieStore.Models.DTO;

namespace MovieStore.DL.Repositories.MongoRepositories
{
    internal class MovieStaticDataRepository : IMovieRepository
    {
        //public List<Movie> GetAll()
        //{
        //    return StaticDb.Movies;
        //}

        //public Movie? GetById(string id)
        //{
        //    if (string.IsNullOrEmpty(id)) return null;

        //    return StaticDb.Movies
        //        .FirstOrDefault(x => x.Id == id);
        //}
        public Task Add(Movie movie)
        {
            throw new NotImplementedException();
        }

        public Task<List<Movie>> GetAll()
        {
            return StaticDb.Movies;
        }

        public Task<Movie?> GetById(string id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Movie movie)
        {
            throw new NotImplementedException();
        }
    }


}
