using Stormancer.Plugins;
using Stormancer.Server.Configuration;

namespace Stormancer.Server.Configuration
{
    public class ConfigurationManagerPlugin : IHostPlugin
    {
        public void Build(HostPluginBuildContext ctx)
        {
          
            ctx.HostDependenciesRegistration += RegisterHost;
        }

        private static void RegisterHost(IDependencyBuilder builder)
        {
            builder.Register<ConfigurationService>().SingleInstance();
            builder.Register<EnvironmentConfiguration>().As<IConfiguration>();
        }
    }
}
