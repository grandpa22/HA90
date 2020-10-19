using Abp.Application.Services;
using ArtmisNet.Ha90.MultiTenancy.Dto;

namespace ArtmisNet.Ha90.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

