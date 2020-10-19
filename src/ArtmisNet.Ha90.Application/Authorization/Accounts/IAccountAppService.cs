using System.Threading.Tasks;
using Abp.Application.Services;
using ArtmisNet.Ha90.Authorization.Accounts.Dto;

namespace ArtmisNet.Ha90.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
