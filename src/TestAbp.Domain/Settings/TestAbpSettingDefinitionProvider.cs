using Volo.Abp.Settings;

namespace TestAbp.Settings;

public class TestAbpSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(TestAbpSettings.MySetting1));
    }
}
