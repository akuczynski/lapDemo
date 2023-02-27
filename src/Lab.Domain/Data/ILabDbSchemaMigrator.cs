using System.Threading.Tasks;

namespace Lab.Data;

public interface ILabDbSchemaMigrator
{
    Task MigrateAsync();
}
