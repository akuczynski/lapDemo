using Lab.Measurement.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Lab.Measurement.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class MeasurementPageModel : AbpPageModel
{
    protected MeasurementPageModel()
    {
        LocalizationResourceType = typeof(MeasurementResource);
        ObjectMapperContext = typeof(MeasurementWebModule);
    }
}
