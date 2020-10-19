using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ArtmisNet.Ha90.Configuration.Dto;

namespace ArtmisNet.Ha90.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : Ha90AppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
