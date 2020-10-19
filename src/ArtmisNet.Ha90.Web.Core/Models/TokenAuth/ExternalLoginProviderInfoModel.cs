using Abp.AutoMapper;
using ArtmisNet.Ha90.Authentication.External;

namespace ArtmisNet.Ha90.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
