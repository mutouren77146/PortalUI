using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace COM.PortalUI.EntityFrameworkCore
{
    public static class PortalUIDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<PortalUIDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<PortalUIDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
