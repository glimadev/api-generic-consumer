
using System.Threading.Tasks;
namespace ApiConsumer.Services.Api
{
    public interface IApiService<T> where T : class, IResultService
    {
        Task<T> Post(string controller, string action, string data);
        Task<T> Get(string controller, string action, string data);
    }
}
