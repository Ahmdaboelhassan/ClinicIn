using ClinicIn.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace ClinicIn.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ClinicInEntityFrameworkCoreModule),
    typeof(ClinicInApplicationContractsModule)
)]
public class ClinicInDbMigratorModule : AbpModule
{
}
