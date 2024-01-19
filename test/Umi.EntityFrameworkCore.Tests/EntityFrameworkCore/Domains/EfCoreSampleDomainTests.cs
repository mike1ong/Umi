using Umi.Samples;
using Xunit;

namespace Umi.EntityFrameworkCore.Domains;

[Collection(UmiTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<UmiEntityFrameworkCoreTestModule>
{

}
