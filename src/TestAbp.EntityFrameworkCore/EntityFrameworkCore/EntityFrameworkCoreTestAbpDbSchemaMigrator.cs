using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TestAbp.Data;
using Volo.Abp.DependencyInjection;

namespace TestAbp.EntityFrameworkCore;

public class EntityFrameworkCoreTestAbpDbSchemaMigrator
    : ITestAbpDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreTestAbpDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the TestAbpDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<TestAbpDbContext>()
            .Database
            .MigrateAsync();
    }
}
