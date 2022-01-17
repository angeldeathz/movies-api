using System.Threading.Tasks;
using Movies.Proxy.Proxies.Movies;
using Movies.Services.Responses;

namespace Movies.Services.Services.Movies
{
    public class MovieService : IMovieService
    {
        private readonly IMovieProxy _movieProxy;

        public MovieService(IMovieProxy movieProxy)
        {
            _movieProxy = movieProxy;
        }

        public async Task<SearchMovieResponse> SearchMovie(string name, string languaje)
        {
            var query = $"query={name}&language={languaje}";
            var movies = await _movieProxy.SearchMovie(query);
            return new SearchMovieResponse().Map(movies);
        }
    }
}