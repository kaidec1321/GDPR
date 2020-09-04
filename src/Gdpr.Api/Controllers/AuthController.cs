using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Gdpr.Api.Core.Interfaces.UseCases;
using Gdpr.Api.Presenters;
using Gdpr.Api.Core.Dto.UseCaseRequests;

namespace Gdpr.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly ILoginUseCase _loginUseCase;
        private readonly LoginPresenter _loginPresenter;

        public AuthController(ILoginUseCase loginUseCase, LoginPresenter loginPresenter) 
        {
            _loginUseCase = loginUseCase;
            _loginPresenter = loginPresenter;
        }

        [HttpPost("login")]
        public async Task<ActionResult> Login([FromBody] LoginRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _loginUseCase.Handle(new LoginRequest(request.Email, request.Password), _loginPresenter);
            return _loginPresenter.contentResult;
        }
    }
}