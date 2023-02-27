using Lab.Measurement.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Lab.Measurement.Blazor.Server.Host;

public abstract class MeasurementComponentBase : AbpComponentBase
{
    protected MeasurementComponentBase()
    {
        LocalizationResource = typeof(MeasurementResource);
    }
}
