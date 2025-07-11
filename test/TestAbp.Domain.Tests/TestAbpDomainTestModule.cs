using Volo.Abp.Modularity;

namespace TestAbp;

[DependsOn(
    typeof(TestAbpDomainModule),
    typeof(TestAbpTestBaseModule)
)]
public class TestAbpDomainTestModule : AbpModule
{

}
