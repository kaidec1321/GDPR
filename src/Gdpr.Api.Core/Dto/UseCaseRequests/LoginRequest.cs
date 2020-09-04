using Gdpr.Api.Core.Interfaces;
using Gdpr.Api.Core.Dto.UseCaseResponses;

namespace Gdpr.Api.Core.Dto.UseCaseRequests
{
    public class LoginRequest : IUseCaseRequest<LoginResponse>
    {
        public string Email { get; }
        public string Password { get; }

        public LoginRequest(string email, string password)
        {
            Email = email;
            Password = password;
        }
    }
}