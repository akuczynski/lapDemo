using Lab.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Lab.Blazor;

public abstract class LabComponentBase : AbpComponentBase
{
    protected LabComponentBase()
    {
        LocalizationResource = typeof(LabResource);
    }
}
