using Lab.Instruments.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Lab.Instruments.Permissions;

public class InstrumentsPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(InstrumentsPermissions.GroupName, L("Permission:Instruments"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<InstrumentsResource>(name);
    }
}
