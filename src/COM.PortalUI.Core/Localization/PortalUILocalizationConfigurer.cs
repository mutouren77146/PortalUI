using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace COM.PortalUI.Localization
{
    public static class PortalUILocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(PortalUIConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(PortalUILocalizationConfigurer).GetAssembly(),
                        "COM.PortalUI.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
