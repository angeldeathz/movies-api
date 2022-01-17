using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Movies.Proxy.Responses;
using Movies.Services.Services.Movies;

namespace Movies.API.Controllers.V1
{
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieService _movieService;

        public MoviesController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet("search")]
        public async Task<ActionResult<SearchMovieProxyResponse>> Get([FromQuery] string query,
            [FromQuery] string language)
        {
            var response = await _movieService.SearchMovie(query, language);
            return Ok(response);
        }
    }
}