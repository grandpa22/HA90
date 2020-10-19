using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ArtmisNet.Ha90.Controllers
{
    public abstract class Ha90ControllerBase: AbpController
    {
        protected Ha90ControllerBase()
        {
            LocalizationSourceName = Ha90Consts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
