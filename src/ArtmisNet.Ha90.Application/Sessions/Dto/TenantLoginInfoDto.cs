using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using ArtmisNet.Ha90.MultiTenancy;

namespace ArtmisNet.Ha90.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
