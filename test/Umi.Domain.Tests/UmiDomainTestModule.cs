using Volo.Abp.Modularity;

namespace Umi;

[DependsOn(
    typeof(UmiDomainModule),
    typeof(UmiTestBaseModule)
)]
public class UmiDomainTestModule : AbpModule
{

}
