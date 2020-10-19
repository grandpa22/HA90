using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace ArtmisNet.Ha90.Localization
{
    public static class Ha90LocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(Ha90Consts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(Ha90LocalizationConfigurer).GetAssembly(),
                        "ArtmisNet.Ha90.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
