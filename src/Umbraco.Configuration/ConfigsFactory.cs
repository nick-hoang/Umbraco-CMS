using Umbraco.Configuration;
using Umbraco.Configuration.Implementations;
using Umbraco.Core.Configuration.HealthChecks;
using Umbraco.Core.Configuration.Implementations;
using Umbraco.Core.Configuration.UmbracoSettings;

namespace Umbraco.Core.Configuration
{
    public class ConfigsFactory : IConfigsFactory
    {
        public IHostingSettings HostingSettings { get; } = new HostingSettings();
        public ICoreDebug CoreDebug { get; } = new CoreDebug();
        public IMachineKeyConfig MachineKeyConfig { get; } = new MachineKeyConfig();
        public IIndexCreatorSettings IndexCreatorSettings { get; } = new IndexCreatorSettings();
        public INuCacheSettings NuCacheSettings { get; } = new NuCacheSettings();
        public ITypeFinderSettings TypeFinderSettings { get; } = new TypeFinderSettings();
        public IRuntimeSettings RuntimeSettings { get; } = new RuntimeSettings();
        public IActiveDirectorySettings ActiveDirectorySettings { get; } = new ActiveDirectorySettings();
        public IExceptionFilterSettings ExceptionFilterSettings { get; } = new ExceptionFilterSettings();
        public ITourSettings TourSettings { get; } = new TourSettings();
        public ILoggingSettings LoggingSettings { get; } = new LoggingSettings();
        public IKeepAliveSettings KeepAliveSettings { get; } = new KeepAliveSettings();
        public IWebRoutingSettings WebRoutingSettings { get; } = new WebRoutingSettings();
        public IRequestHandlerSettings RequestHandlerSettings { get; } = new RequestHandlerSettings();
        public ISecuritySettings SecuritySettings { get; } = new SecuritySettings();
        public IUserPasswordConfiguration UserPasswordConfigurationSettings { get; } = new UserPasswordConfigurationSettings();
        public IMemberPasswordConfiguration MemberPasswordConfigurationSettings { get; } = new MemberPasswordConfigurationSettings();
        public IContentSettings ContentSettings { get; } = new ContentSettings();
        public IGlobalSettings GlobalSettings { get; } = new GlobalSettings();
        public IHealthChecks HealthChecksSettings { get; } = new HealthChecksSettings();
        public IConnectionStrings ConnectionStrings { get; } = new ConnectionStrings();
        public IModelsBuilderConfig ModelsBuilderConfig { get; } = new ModelsBuilderConfig();

        public Configs Create()
        {
            var configs =  new Configs();

            configs.Add<IGlobalSettings>(() => GlobalSettings);
            configs.Add<IHostingSettings>(() => HostingSettings);
            configs.Add<IHealthChecks>(() => HealthChecksSettings);
            configs.Add<ICoreDebug>(() => CoreDebug);
            configs.Add<IMachineKeyConfig>(() => MachineKeyConfig);
            configs.Add<IConnectionStrings>(() => ConnectionStrings);
            configs.Add<IModelsBuilderConfig>(() => ModelsBuilderConfig);
            configs.Add<IIndexCreatorSettings>(() => IndexCreatorSettings);
            configs.Add<INuCacheSettings>(() => NuCacheSettings);
            configs.Add<ITypeFinderSettings>(() => TypeFinderSettings);
            configs.Add<IRuntimeSettings>(() => RuntimeSettings);
            configs.Add<IActiveDirectorySettings>(() => ActiveDirectorySettings);
            configs.Add<IExceptionFilterSettings>(() => ExceptionFilterSettings);
            configs.Add<ITourSettings>(() => TourSettings);
            configs.Add<ILoggingSettings>(() => LoggingSettings);
            configs.Add<IKeepAliveSettings>(() => KeepAliveSettings);
            configs.Add<IWebRoutingSettings>(() => WebRoutingSettings);
            configs.Add<IRequestHandlerSettings>(() => RequestHandlerSettings);
            configs.Add<ISecuritySettings>(() => SecuritySettings);
            configs.Add<IUserPasswordConfiguration>(() => UserPasswordConfigurationSettings);
            configs.Add<IMemberPasswordConfiguration>(() => MemberPasswordConfigurationSettings);
            configs.Add<IContentSettings>(() => ContentSettings);

            return configs;
        }
    }
}