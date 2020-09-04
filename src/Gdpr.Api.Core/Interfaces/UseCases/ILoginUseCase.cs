using Gdpr.Api.Core.Dto.UseCaseRequests;
using Gdpr.Api.Core.Dto.UseCaseResponses;

namespace Gdpr.Api.Core.Interfaces.UseCases
{
    public interface ILoginUseCase : IUseCaseRequestHandle<LoginRequest, LoginResponse>
    {
        
    }
}