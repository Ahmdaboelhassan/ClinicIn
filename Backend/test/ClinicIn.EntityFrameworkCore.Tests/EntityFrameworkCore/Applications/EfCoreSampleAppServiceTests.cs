using ClinicIn.Samples;
using Xunit;

namespace ClinicIn.EntityFrameworkCore.Applications;

[Collection(ClinicInTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<ClinicInEntityFrameworkCoreTestModule>
{

}
