using Volo.Abp.Modularity;

namespace TestAbp;

[DependsOn(
    typeof(TestAbpApplicationModule),
    typeof(TestAbpDomainTestModule)
)]
public class TestAbpApplicationTestModule : AbpModule
{

}
