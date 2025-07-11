using System.Threading.Tasks;

namespace TestAbp.Data;

public interface ITestAbpDbSchemaMigrator
{
    Task MigrateAsync();
}
