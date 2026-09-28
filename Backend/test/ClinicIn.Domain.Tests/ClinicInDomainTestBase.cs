using Volo.Abp.Modularity;

namespace ClinicIn;

/* Inherit from this class for your domain layer tests. */
public abstract class ClinicInDomainTestBase<TStartupModule> : ClinicInTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
