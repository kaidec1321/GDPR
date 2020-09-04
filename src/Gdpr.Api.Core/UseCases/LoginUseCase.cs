using System.Threading.Tasks;
using Gdpr.Api.Core.Dto;
using Gdpr.Api.Core.Dto.UseCaseRequests;
using Gdpr.Api.Core.Dto.UseCaseResponses;
using Gdpr.Api.Core.Interfaces;
using Gdpr.Api.Core.Interfaces.UseCases;
using Gdpr.Api.Core.Interfaces.Gateways;
using Gdpr.Api.Core.Interfaces.Services;

namespace Gdpr.Api.Core.UseCases
{
    public sealed class LoginUseCase : ILoginUseCase
    {
        private readonly IUserRepository _userRepository;
        private readonly IJwtFactory _jwtFactory;

        public LoginUseCase(IUserRepository userRepository, IJwtFactory jwtFactory)
        {
            _userRepository = userRepository;
            _jwtFactory = jwtFactory;
        }

        public async Task<bool> Handle(LoginRequest message, IOutputPort<LoginResponse> outputPort)
        {
            if (!string.IsNullOrEmpty(message.Email) && !string.IsNullOrEmpty(message.Password))
            {
                // confirm we have a user with the given name
                var user = _userRepository.CheckPassword(message.Email, message.Password);
                if (user != null)
                {
                    outputPort.Handle(new LoginResponse(await _jwtFactory.GenerateEncodedToken(user.Id, user.Email, user.Role), true));
                    return true;
                }
            }
            outputPort.Handle(new LoginResponse(new[] { new Error("login_failure", "Invalid username or password.") }));
            return false;
        }
    }
}