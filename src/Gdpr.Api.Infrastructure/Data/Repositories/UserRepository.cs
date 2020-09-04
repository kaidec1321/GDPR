using AutoMapper;
using System.Threading.Tasks;
using Gdpr.Api.Core.Interfaces.Gateways;
using Gdpr.Api.Core.Dto.GatewayResponses;
using Gdpr.Api.Core.Domain.Entities;
using Gdpr.Api.Infrastructure.Data.Entities;
using System.Linq;

namespace Gdpr.Api.Infrastructure.Data.Repositories
{
    internal sealed class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _userManager;
        private readonly IMapper _mapper;

        public UserRepository(ApplicationDbContext userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        //public async Task<CreateUserResponse> Create(string Email)
        //{
        //    var appUser = _mapper.Map<AppUser>(user);
        //    var identityResult = await _userManager.CreateAsync(appUser, password);
        //    // return new CreateUserResponse(appUser.Id, identityResult.Succeeded, identityResult.Succeeded ? null : identityResult.Errors.Select(e => new Error(e.Code, e.Description)));
        //}

        public User CheckPassword(string email, string password)
        {
            return _mapper.Map<User>(_userManager.AppUsers.FirstOrDefault(au => (au.Email == email) && (au.PasswordHash == password)));
        }
    }
}
