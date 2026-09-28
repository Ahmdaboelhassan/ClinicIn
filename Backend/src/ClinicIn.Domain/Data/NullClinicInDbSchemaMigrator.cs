using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ClinicIn.Data;

/* This is used if database provider does't define
 * IClinicInDbSchemaMigrator implementation.
 */
public class NullClinicInDbSchemaMigrator : IClinicInDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
