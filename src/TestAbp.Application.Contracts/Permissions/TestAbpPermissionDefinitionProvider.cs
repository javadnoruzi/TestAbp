using TestAbp.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace TestAbp.Permissions;

public class TestAbpPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(TestAbpPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(TestAbpPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<TestAbpResource>(name);
    }
}
