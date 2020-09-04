using System.Threading.Tasks;
using Gdpr.Api.Core.Domain.Entities;
using Gdpr.Api.Core.Dto.GatewayResponses;

namespace Gdpr.Api.Core.Interfaces.Gateways
{
    public interface IUserRepository
    {
        User CheckPassword(string email, string password);
    }
}