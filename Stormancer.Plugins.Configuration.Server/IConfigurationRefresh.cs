namespace Stormancer.Server.Configuration
{
    public interface IConfigurationRefresh
    {
        void Init(dynamic config);
        void ConfigChanged(dynamic newConfig);
    }
}
