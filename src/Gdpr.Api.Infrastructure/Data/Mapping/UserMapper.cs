using AutoMapper;
using Gdpr.Api.Core.Domain.Entities;
using Gdpr.Api.Infrastructure.Data.Models;

namespace Gdpr.Api.Infrastructure.Data.Mapping
{
    public class DataProfile : Profile
    {
        public DataProfile()
        {
            CreateMap<User, AppUser>().ConstructUsing(u => new AppUser(u.FirstName, u.LastName, u.Email, u.PasswordHash, u.Id, u.Role));
            CreateMap<AppUser, User>().ConstructUsing(au => new User(au.FirstName, au.LastName, au.Email, au.Role, au.PasswordHash, au.Id));
        }
    }
}