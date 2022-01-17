using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Movies.Proxy.Http;
using Movies.Proxy.Responses;

namespace Movies.Proxy.Proxies.Movies
{
    public class MovieProxy : IMovieProxy
    {
        private readonly IConfiguration _configuration;
        private readonly IHttpService _httpService;

        public MovieProxy(IHttpService httpService, IConfiguration configuration)
        {
            _httpService = httpService;
            _configuration = configuration;
        }

        public Task<SearchMovieProxyResponse> SearchMovie(string query)
        {
            var token = _configuration.GetSection("MovieDbToken").Value;
            var url = $"{_configuration.GetSection("MovieDbUrl").Value}search/movie?{query}";
            return _httpService.Get<SearchMovieProxyResponse>(url, token);
        }
    }
}