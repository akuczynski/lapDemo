using Lab.Instruments.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Lab.Instruments;

public abstract class InstrumentsController : AbpControllerBase
{
    protected InstrumentsController()
    {
        LocalizationResource = typeof(InstrumentsResource);
    }
}
