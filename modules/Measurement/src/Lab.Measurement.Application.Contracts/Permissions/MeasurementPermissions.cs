using Volo.Abp.Reflection;

namespace Lab.Measurement.Permissions;

public class MeasurementPermissions
{
    public const string GroupName = "Measurement";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(MeasurementPermissions));
    }
}
