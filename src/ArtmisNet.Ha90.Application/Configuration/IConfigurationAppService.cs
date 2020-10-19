using System.Threading.Tasks;
using ArtmisNet.Ha90.Configuration.Dto;

namespace ArtmisNet.Ha90.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
