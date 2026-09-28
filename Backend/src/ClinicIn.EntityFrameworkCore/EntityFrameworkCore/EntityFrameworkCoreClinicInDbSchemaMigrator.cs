using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ClinicIn.Data;
using Volo.Abp.DependencyInjection;

namespace ClinicIn.EntityFrameworkCore;

public class EntityFrameworkCoreClinicInDbSchemaMigrator
    : IClinicInDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreClinicInDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the ClinicInDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<ClinicInDbContext>()
            .Database
            .MigrateAsync();
    }
}
