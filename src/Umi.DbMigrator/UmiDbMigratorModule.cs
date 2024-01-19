using Umi.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Umi.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(UmiEntityFrameworkCoreModule),
    typeof(UmiApplicationContractsModule)
    )]
public class UmiDbMigratorModule : AbpModule
{
}
