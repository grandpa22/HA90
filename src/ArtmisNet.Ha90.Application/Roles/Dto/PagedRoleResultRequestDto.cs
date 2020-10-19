using Abp.Application.Services.Dto;

namespace ArtmisNet.Ha90.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

