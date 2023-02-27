using Localization.Resources.AbpUi;
using Lab.Measurement.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace Lab.Measurement;

[DependsOn(
    typeof(MeasurementApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class MeasurementHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(MeasurementHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<MeasurementResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
