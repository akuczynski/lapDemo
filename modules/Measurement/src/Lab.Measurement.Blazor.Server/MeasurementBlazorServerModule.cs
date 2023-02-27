using Volo.Abp.AspNetCore.Components.Server.Theming;
using Volo.Abp.Modularity;

namespace Lab.Measurement.Blazor.Server;

[DependsOn(
    typeof(AbpAspNetCoreComponentsServerThemingModule),
    typeof(MeasurementBlazorModule)
    )]
public class MeasurementBlazorServerModule : AbpModule
{

}
