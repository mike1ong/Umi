using Umi.Samples;
using Xunit;

namespace Umi.EntityFrameworkCore.Applications;

[Collection(UmiTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<UmiEntityFrameworkCoreTestModule>
{

}
