using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace TestAbp.Data;

/* This is used if database provider does't define
 * ITestAbpDbSchemaMigrator implementation.
 */
public class NullTestAbpDbSchemaMigrator : ITestAbpDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
