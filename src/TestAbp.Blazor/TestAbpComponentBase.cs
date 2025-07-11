using TestAbp.Localization;
using Volo.Abp.AspNetCore.Components;

namespace TestAbp.Blazor;

public abstract class TestAbpComponentBase : AbpComponentBase
{
    protected TestAbpComponentBase()
    {
        LocalizationResource = typeof(TestAbpResource);
    }
}
