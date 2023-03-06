using Volo.Abp.Reflection;

namespace Lab.Instruments.Permissions;

public class InstrumentsPermissions
{
    public const string GroupName = "Instruments";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(InstrumentsPermissions));
    }
}
