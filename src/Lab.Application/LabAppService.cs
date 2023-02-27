using System;
using System.Collections.Generic;
using System.Text;
using Lab.Localization;
using Volo.Abp.Application.Services;

namespace Lab;

/* Inherit your application services from this class.
 */
public abstract class LabAppService : ApplicationService
{
    protected LabAppService()
    {
        LocalizationResource = typeof(LabResource);
    }
}
