using Localization.Resources.AbpUi;
using Lab.Instruments.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace Lab.Instruments;

[DependsOn(
    typeof(InstrumentsApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class InstrumentsHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(InstrumentsHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<InstrumentsResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
