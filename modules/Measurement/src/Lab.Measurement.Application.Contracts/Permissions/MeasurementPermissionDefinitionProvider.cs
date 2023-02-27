using Lab.Measurement.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Lab.Measurement.Permissions;

public class MeasurementPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(MeasurementPermissions.GroupName, L("Permission:Measurement"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<MeasurementResource>(name);
    }
}
