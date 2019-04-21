using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using COM.PortalUI.Authorization;

namespace COM.PortalUI
{
    [DependsOn(
        typeof(PortalUICoreModule), 
        typeof(AbpAutoMapperModule))]
    public class PortalUIApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<PortalUIAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(PortalUIApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
