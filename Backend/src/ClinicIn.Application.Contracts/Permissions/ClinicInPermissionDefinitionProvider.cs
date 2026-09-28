using ClinicIn.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace ClinicIn.Permissions;

public class ClinicInPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ClinicInPermissions.GroupName);

        //Define your own permissions here. Example:
        //myGroup.AddPermission(ClinicInPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ClinicInResource>(name);
    }
}
