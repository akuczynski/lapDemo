using Microsoft.Extensions.DependencyInjection;
using Lab.Instruments.Blazor.Menus;
using Volo.Abp.AspNetCore.Components.Web.Theming;
using Volo.Abp.AspNetCore.Components.Web.Theming.Routing;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.UI.Navigation;

namespace Lab.Instruments.Blazor;

[DependsOn(
    typeof(InstrumentsApplicationContractsModule),
    typeof(AbpAspNetCoreComponentsWebThemingModule),
    typeof(AbpAutoMapperModule)
    )]
public class InstrumentsBlazorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAutoMapperObjectMapper<InstrumentsBlazorModule>();

        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddProfile<InstrumentsBlazorAutoMapperProfile>(validate: true);
        });

        Configure<AbpNavigationOptions>(options =>
        {
            options.MenuContributors.Add(new InstrumentsMenuContributor());
        });

        Configure<AbpRouterOptions>(options =>
        {
            options.AdditionalAssemblies.Add(typeof(InstrumentsBlazorModule).Assembly);
        });
    }
}
