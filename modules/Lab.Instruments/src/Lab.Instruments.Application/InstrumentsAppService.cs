using Lab.Instruments.Localization;
using Volo.Abp.Application.Services;

namespace Lab.Instruments;

public abstract class InstrumentsAppService : ApplicationService
{
    protected InstrumentsAppService()
    {
        LocalizationResource = typeof(InstrumentsResource);
        ObjectMapperContext = typeof(InstrumentsApplicationModule);
    }
}
