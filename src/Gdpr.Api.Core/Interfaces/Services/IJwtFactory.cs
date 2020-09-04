using System.Threading.Tasks;
using Gdpr.Api.Core.Dto;

namespace Gdpr.Api.Core.Interfaces.Services
{
    public interface IJwtFactory
    {
        Task<Token> GenerateEncodedToken(string id, string email, int role);
    }
}