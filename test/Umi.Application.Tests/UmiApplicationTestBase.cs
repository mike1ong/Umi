using Volo.Abp.Modularity;

namespace Umi;

public abstract class UmiApplicationTestBase<TStartupModule> : UmiTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
