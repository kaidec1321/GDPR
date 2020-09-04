using Autofac;
using Gdpr.Api.Core.Interfaces.UseCases;
using Gdpr.Api.Core.UseCases;

namespace Gdpr.Api.Core
{
  public class CoreModule : Module
  {
    protected override void Load(ContainerBuilder builder)
    {
      builder.RegisterType<LoginUseCase>().As<ILoginUseCase>().InstancePerLifetimeScope();
    }
  }
}
