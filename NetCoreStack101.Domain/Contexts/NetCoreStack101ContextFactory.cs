using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Options;
using NetCoreStack.Data;
using NetCoreStack.Data.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreStack101.Domain.Contexts
{
    public class NetCoreStack101ContextFactory: IDesignTimeDbContextFactory<NetCoreStack101Context>
    {
        public NetCoreStack101Context CreateDbContext(string[] args)
        {
            var connectionString = "Server=.;Database=NetCoreStack101Db;Trusted_Connection=True;MultipleActiveResultSets=true";

            var options = Options.Create(new DbSettings
            {
                SqlConnectionString = connectionString
            });

            var dataContextConfigurationAccessor = new DataContextConfigurationAccessor(options);
            var optionsBuilder = new DbContextOptionsBuilder<NetCoreStack101Context>();
            optionsBuilder.UseSqlServer(connectionString);

            return new NetCoreStack101Context(dataContextConfigurationAccessor);
        }
    }
}
