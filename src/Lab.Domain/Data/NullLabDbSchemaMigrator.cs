using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Lab.Data;

/* This is used if database provider does't define
 * ILabDbSchemaMigrator implementation.
 */
public class NullLabDbSchemaMigrator : ILabDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
