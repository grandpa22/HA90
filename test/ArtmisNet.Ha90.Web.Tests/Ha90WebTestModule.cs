using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ArtmisNet.Ha90.EntityFrameworkCore;
using ArtmisNet.Ha90.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace ArtmisNet.Ha90.Web.Tests
{
    [DependsOn(
        typeof(Ha90WebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class Ha90WebTestModule : AbpModule
    {
        public Ha90WebTestModule(Ha90EntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Ha90WebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(Ha90WebMvcModule).Assembly);
        }
    }
}