using System.Threading.Tasks;

namespace ClinicIn.Data;

public interface IClinicInDbSchemaMigrator
{
    Task MigrateAsync();
}
