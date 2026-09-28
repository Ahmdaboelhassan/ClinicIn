using Volo.Abp.Modularity;

namespace ClinicIn;

[DependsOn(
    typeof(ClinicInDomainModule),
    typeof(ClinicInTestBaseModule)
)]
public class ClinicInDomainTestModule : AbpModule
{

}
