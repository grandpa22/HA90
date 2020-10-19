using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ArtmisNet.Ha90.Authorization.Roles;
using ArtmisNet.Ha90.Authorization.Users;
using ArtmisNet.Ha90.MultiTenancy;

namespace ArtmisNet.Ha90.EntityFrameworkCore
{
    public class Ha90DbContext : AbpZeroDbContext<Tenant, Role, User, Ha90DbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public Ha90DbContext(DbContextOptions<Ha90DbContext> options)
            : base(options)
        {
        }
    }
}
