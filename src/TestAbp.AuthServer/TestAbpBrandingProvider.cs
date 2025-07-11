using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace TestAbp;

[Dependency(ReplaceServices = true)]
public class TestAbpBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "TestAbp";
}
