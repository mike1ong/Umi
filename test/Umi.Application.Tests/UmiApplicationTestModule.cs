using Volo.Abp.Modularity;

namespace Umi;

[DependsOn(
    typeof(UmiApplicationModule),
    typeof(UmiDomainTestModule)
)]
public class UmiApplicationTestModule : AbpModule
{

}
