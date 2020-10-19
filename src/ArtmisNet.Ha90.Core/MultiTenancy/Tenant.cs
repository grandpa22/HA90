using Abp.MultiTenancy;
using ArtmisNet.Ha90.Authorization.Users;

namespace ArtmisNet.Ha90.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
