using System.Collections.Generic;

namespace ArtmisNet.Ha90.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
