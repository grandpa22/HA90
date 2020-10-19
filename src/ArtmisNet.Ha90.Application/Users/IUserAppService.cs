using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ArtmisNet.Ha90.Roles.Dto;
using ArtmisNet.Ha90.Users.Dto;

namespace ArtmisNet.Ha90.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);

        Task<bool> ChangePassword(ChangePasswordDto input);
    }
}
