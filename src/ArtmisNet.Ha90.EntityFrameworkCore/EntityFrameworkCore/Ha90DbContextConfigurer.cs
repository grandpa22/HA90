using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ArtmisNet.Ha90.EntityFrameworkCore
{
    public static class Ha90DbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<Ha90DbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<Ha90DbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
