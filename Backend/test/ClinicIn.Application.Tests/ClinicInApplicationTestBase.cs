using Volo.Abp.Modularity;

namespace ClinicIn;

public abstract class ClinicInApplicationTestBase<TStartupModule> : ClinicInTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
