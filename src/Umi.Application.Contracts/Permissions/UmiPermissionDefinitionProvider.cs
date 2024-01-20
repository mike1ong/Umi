using Umi.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Umi.Permissions;

public class UmiPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(UmiPermissions.GroupName, L("Permission:Umi"));
        //Define your own permissions here. Example:
        //myGroup.AddPermission(UmiPermissions.MyPermission1, L("Permission:MyPermission1"));
        var shopsPermission = myGroup.AddPermission(UmiPermissions.Shops.Default, L("Permission:Shops"));
        shopsPermission.AddChild(UmiPermissions.Shops.Create, L("Permission:Shops.Create"));
        shopsPermission.AddChild(UmiPermissions.Shops.Edit, L("Permission:Shops.Edit"));
        shopsPermission.AddChild(UmiPermissions.Shops.Delete, L("Permission:Shops.Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<UmiResource>(name);
    }
}
