using System.Threading.Tasks;
using Movies.Proxy.Responses;

namespace Movies.Proxy.Proxies.Movies
{
    public interface IMovieProxy
    {
        Task<SearchMovieProxyResponse> SearchMovie(string query);
    }
}