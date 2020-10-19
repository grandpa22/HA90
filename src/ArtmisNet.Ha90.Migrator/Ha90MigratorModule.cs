using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ArtmisNet.Ha90.Configuration;
using ArtmisNet.Ha90.EntityFrameworkCore;
using ArtmisNet.Ha90.Migrator.DependencyInjection;

namespace ArtmisNet.Ha90.Migrator
{
    [DependsOn(typeof(Ha90EntityFrameworkModule))]
    public class Ha90MigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public Ha90MigratorModule(Ha90EntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(Ha90MigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                Ha90Consts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Ha90MigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
