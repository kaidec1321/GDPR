using System.Threading.Tasks;

namespace Gdpr.Api.Core.Interfaces 
{
    public interface IUseCaseRequestHandle<in TUseCaseRequest, out TUseCaseResponse> where TUseCaseRequest : IUseCaseRequest<TUseCaseResponse> 
    {
        Task<bool> Handle(TUseCaseRequest message, IOutputPort<TUseCaseResponse> outputPort);
    }
}