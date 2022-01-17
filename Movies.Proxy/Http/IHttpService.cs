using System.Threading.Tasks;

namespace Movies.Proxy.Http
{
    public interface IHttpService
    {
        Task<T> Get<T>(string url, string token);
    }
}