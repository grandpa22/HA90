using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ArtmisNet.Ha90.Configuration;
using ArtmisNet.Ha90.Web;

namespace ArtmisNet.Ha90.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class Ha90DbContextFactory : IDesignTimeDbContextFactory<Ha90DbContext>
    {
        public Ha90DbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<Ha90DbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            Ha90DbContextConfigurer.Configure(builder, configuration.GetConnectionString(Ha90Consts.ConnectionStringName));

            return new Ha90DbContext(builder.Options);
        }
    }
}
