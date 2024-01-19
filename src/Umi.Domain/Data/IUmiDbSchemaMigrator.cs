using System.Threading.Tasks;

namespace Umi.Data;

public interface IUmiDbSchemaMigrator
{
    Task MigrateAsync();
}
