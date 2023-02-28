using Volo.Abp.Reflection;

namespace Lab.Measurement.Permissions;

public class MeasurementPermissions
{
    public const string GroupName = "Measurement";

    public static class Samples
    {
        public const string Default = GroupName + ".Samples";

        public const string Delete = Default + ".Delete";
        //public const string Update = Default + ".Update";
        public const string Create = Default + ".Create";
    }

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(MeasurementPermissions));
    }
}
