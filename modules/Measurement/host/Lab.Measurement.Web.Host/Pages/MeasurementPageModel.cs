using Lab.Measurement.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Lab.Measurement.Pages;

public abstract class MeasurementPageModel : AbpPageModel
{
    protected MeasurementPageModel()
    {
        LocalizationResourceType = typeof(MeasurementResource);
    }
}
