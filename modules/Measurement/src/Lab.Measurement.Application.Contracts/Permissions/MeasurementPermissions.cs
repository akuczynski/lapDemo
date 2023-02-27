using Volo.Abp.Reflection;

namespace Lab.Measurement.Permissions;

public class MeasurementPermissions
{
    public const string GroupName = "Measurement";

    public const string SampleGet = GroupName + "Get_Samples";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(MeasurementPermissions));
    }
}
