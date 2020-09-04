using Autofac;
using Gdpr.Api.Core.Interfaces.Gateways;
using Gdpr.Api.Core.Interfaces.Services;
using Gdpr.Api.Infrastructure.Auth;
using Gdpr.Api.Infrastructure.Data.Repositories;

namespace Gdpr.Api.Infrastructure
{
    public class InfrastructureModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UserRepository>().As<IUserRepository>().InstancePerLifetimeScope();
            builder.RegisterType<JwtFactory>().As<IJwtFactory>().SingleInstance();
        }
    }
}
