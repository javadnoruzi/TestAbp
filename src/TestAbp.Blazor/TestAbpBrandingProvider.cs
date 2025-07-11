using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace TestAbp.Blazor;

[Dependency(ReplaceServices = true)]
public class TestAbpBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "TestAbp";
}
