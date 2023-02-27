using Lab.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Lab.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class LabController : AbpControllerBase
{
    protected LabController()
    {
        LocalizationResource = typeof(LabResource);
    }
}
