using Xunit;

namespace Umi.EntityFrameworkCore;

[CollectionDefinition(UmiTestConsts.CollectionDefinitionName)]
public class UmiEntityFrameworkCoreCollection : ICollectionFixture<UmiEntityFrameworkCoreFixture>
{

}
