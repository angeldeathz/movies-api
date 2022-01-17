using System.Threading.Tasks;
using Movies.Services.Responses;

namespace Movies.Services.Services.Movies
{
    public interface IMovieService
    {
        Task<SearchMovieResponse> SearchMovie(string name, string languaje);
    }
}