using Lab.Measurement.Localization;
using Volo.Abp.Application.Services;

namespace Lab.Measurement;

public abstract class MeasurementAppService : ApplicationService
{
    protected MeasurementAppService()
    {
        LocalizationResource = typeof(MeasurementResource);
        ObjectMapperContext = typeof(MeasurementApplicationModule);
    }
}
