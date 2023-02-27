using Volo.Abp.AspNetCore.Components.WebAssembly.Theming;
using Volo.Abp.Modularity;

namespace Lab.Measurement.Blazor.WebAssembly;

[DependsOn(
    typeof(MeasurementBlazorModule),
    typeof(MeasurementHttpApiClientModule),
    typeof(AbpAspNetCoreComponentsWebAssemblyThemingModule)
    )]
public class MeasurementBlazorWebAssemblyModule : AbpModule
{

}
