using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using ArtmisNet.Ha90.Authorization.Users;
using ArtmisNet.Ha90.Editions;

namespace ArtmisNet.Ha90.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager,
            IAbpZeroFeatureValueStore featureValueStore) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager,
                featureValueStore)
        {
        }
    }
}
