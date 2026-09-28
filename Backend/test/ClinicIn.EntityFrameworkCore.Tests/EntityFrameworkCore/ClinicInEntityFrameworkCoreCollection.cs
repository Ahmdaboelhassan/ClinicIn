using Xunit;

namespace ClinicIn.EntityFrameworkCore;

[CollectionDefinition(ClinicInTestConsts.CollectionDefinitionName)]
public class ClinicInEntityFrameworkCoreCollection : ICollectionFixture<ClinicInEntityFrameworkCoreFixture>
{

}
