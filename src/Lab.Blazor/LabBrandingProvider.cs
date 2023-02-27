using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Lab.Blazor;

[Dependency(ReplaceServices = true)]
public class LabBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Lab";
}
