using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Umi.Data;

/* This is used if database provider does't define
 * IUmiDbSchemaMigrator implementation.
 */
public class NullUmiDbSchemaMigrator : IUmiDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
