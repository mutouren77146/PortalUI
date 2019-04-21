using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using COM.PortalUI.Configuration;
using COM.PortalUI.Web;

namespace COM.PortalUI.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class PortalUIDbContextFactory : IDesignTimeDbContextFactory<PortalUIDbContext>
    {
        public PortalUIDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<PortalUIDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            PortalUIDbContextConfigurer.Configure(builder, configuration.GetConnectionString(PortalUIConsts.ConnectionStringName));

            return new PortalUIDbContext(builder.Options);
        }
    }
}
