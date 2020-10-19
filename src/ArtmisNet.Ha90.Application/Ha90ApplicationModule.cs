using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ArtmisNet.Ha90.Authorization;

namespace ArtmisNet.Ha90
{
    [DependsOn(
        typeof(Ha90CoreModule), 
        typeof(AbpAutoMapperModule))]
    public class Ha90ApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<Ha90AuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(Ha90ApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
