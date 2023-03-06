using Volo.Abp.AspNetCore.Components.Server.Theming;
using Volo.Abp.Modularity;

namespace Lab.Instruments.Blazor.Server;

[DependsOn(
    typeof(AbpAspNetCoreComponentsServerThemingModule),
    typeof(InstrumentsBlazorModule)
    )]
public class InstrumentsBlazorServerModule : AbpModule
{

}
