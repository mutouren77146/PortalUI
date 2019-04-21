using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using COM.PortalUI.Authorization.Roles;
using COM.PortalUI.Authorization.Users;
using COM.PortalUI.MultiTenancy;

namespace COM.PortalUI.EntityFrameworkCore
{
    public class PortalUIDbContext : AbpZeroDbContext<Tenant, Role, User, PortalUIDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public PortalUIDbContext(DbContextOptions<PortalUIDbContext> options)
            : base(options)
        {
        }
    }
}
