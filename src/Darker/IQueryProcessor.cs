using System.Threading.Tasks;

namespace Darker
{
    public interface IQueryProcessor
    {
        TResponse Execute<TResponse>(IQueryRequest<TResponse> request)
            where TResponse : IQueryResponse;

        Task<TResponse> ExecuteAsync<TResponse>(IQueryRequest<TResponse> request)
            where TResponse : IQueryResponse;
    }
}