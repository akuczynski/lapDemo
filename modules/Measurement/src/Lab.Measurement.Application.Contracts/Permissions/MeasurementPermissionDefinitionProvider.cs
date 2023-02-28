using Lab.Measurement.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Lab.Measurement.Permissions;

public class MeasurementPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var group = context.AddGroup(MeasurementPermissions.GroupName, L("Permission:Measurement"));

        var measurments = group.AddPermission(MeasurementPermissions.Samples.Default, L("Permission:Samples"));
        measurments.AddChild(MeasurementPermissions.Samples.Create, L("Permission:Samples:Create"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<MeasurementResource>(name);
    }
}
