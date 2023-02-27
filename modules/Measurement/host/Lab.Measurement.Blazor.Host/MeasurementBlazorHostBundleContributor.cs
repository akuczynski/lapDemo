using Volo.Abp.Bundling;

namespace Lab.Measurement.Blazor.Host;

public class MeasurementBlazorHostBundleContributor : IBundleContributor
{
    public void AddScripts(BundleContext context)
    {

    }

    public void AddStyles(BundleContext context)
    {
        context.Add("main.css", true);
    }
}
