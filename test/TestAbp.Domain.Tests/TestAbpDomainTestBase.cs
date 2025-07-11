using Volo.Abp.Modularity;

namespace TestAbp;

/* Inherit from this class for your domain layer tests. */
public abstract class TestAbpDomainTestBase<TStartupModule> : TestAbpTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
