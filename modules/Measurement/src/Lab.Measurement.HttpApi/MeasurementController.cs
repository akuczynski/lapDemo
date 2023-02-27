using Lab.Measurement.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Lab.Measurement;

public abstract class MeasurementController : AbpControllerBase
{
    protected MeasurementController()
    {
        LocalizationResource = typeof(MeasurementResource);
    }
}
