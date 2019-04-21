using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using COM.PortalUI.Configuration;

namespace COM.PortalUI.Web.Host.Startup
{
    [DependsOn(
       typeof(PortalUIWebCoreModule))]
    public class PortalUIWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public PortalUIWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PortalUIWebHostModule).GetAssembly());
        }
    }
}
