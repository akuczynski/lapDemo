using Volo.Abp.Settings;

namespace Lab.Settings;

public class LabSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(LabSettings.MySetting1));
    }
}
