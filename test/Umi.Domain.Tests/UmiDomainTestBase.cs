using Volo.Abp.Modularity;

namespace Umi;

/* Inherit from this class for your domain layer tests. */
public abstract class UmiDomainTestBase<TStartupModule> : UmiTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
