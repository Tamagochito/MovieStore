using Microsoft.AspNetCore.Mvc;
using MovieStore.BL.Interfaces;
using MovieStore.Models.DTO;

namespace MovieStore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BusinessController : ControllerBase
    {
        private readonly IBusinessService _movieService;

        public BusinessController(IBusinessService movieService)

        {
            _movieService = movieService;
        }

        [HttpGet("GetAllDetailedMovies")]
        public IActionResult GetAllDetailedMovies()
        {
            var result =
                _movieService.GetAllMovies();

            if (result != null && result.Count > 0)
            {
                return Ok(result);
            }

            return NotFound();
        }

    }
}
