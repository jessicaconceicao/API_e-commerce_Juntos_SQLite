using System.Threading.Tasks;

namespace API_Juntos.Application.UseCases
{
    public interface IUseCaseAsync<TRequest, TResponse>
    {
        Task<TResponse> ExecuteAsync(TRequest request);
    }
}
