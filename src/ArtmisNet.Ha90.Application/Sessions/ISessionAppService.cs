using System.Threading.Tasks;
using Abp.Application.Services;
using ArtmisNet.Ha90.Sessions.Dto;

namespace ArtmisNet.Ha90.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
