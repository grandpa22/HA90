using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ArtmisNet.Ha90.Configuration;

namespace ArtmisNet.Ha90.Web.Host.Startup
{
    [DependsOn(
       typeof(Ha90WebCoreModule))]
    public class Ha90WebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public Ha90WebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Ha90WebHostModule).GetAssembly());
        }
    }
}
