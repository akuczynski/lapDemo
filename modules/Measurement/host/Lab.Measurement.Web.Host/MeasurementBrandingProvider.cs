using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Lab.Measurement;

[Dependency(ReplaceServices = true)]
public class MeasurementBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Measurement";
}
