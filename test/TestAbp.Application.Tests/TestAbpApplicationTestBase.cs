using Volo.Abp.Modularity;

namespace TestAbp;

public abstract class TestAbpApplicationTestBase<TStartupModule> : TestAbpTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
