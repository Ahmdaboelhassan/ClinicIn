using Volo.Abp.Modularity;

namespace ClinicIn;

[DependsOn(
    typeof(ClinicInApplicationModule),
    typeof(ClinicInDomainTestModule)
)]
public class ClinicInApplicationTestModule : AbpModule
{

}
