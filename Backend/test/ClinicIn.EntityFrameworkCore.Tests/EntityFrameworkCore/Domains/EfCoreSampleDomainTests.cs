using ClinicIn.Samples;
using Xunit;

namespace ClinicIn.EntityFrameworkCore.Domains;

[Collection(ClinicInTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<ClinicInEntityFrameworkCoreTestModule>
{

}
