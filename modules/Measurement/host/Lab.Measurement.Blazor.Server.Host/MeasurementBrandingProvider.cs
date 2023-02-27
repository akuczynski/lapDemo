using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Lab.Measurement.Blazor.Server.Host;

[Dependency(ReplaceServices = true)]
public class MeasurementBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Measurement";
}
