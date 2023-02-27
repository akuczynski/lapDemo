using Localization.Resources.AbpUi;
using Lab.Localization;
using Volo.Abp.Account;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement.HttpApi;
using Volo.Abp.SettingManagement;
using Volo.Abp.TenantManagement;
using Lab.Measurement;

namespace Lab;

[DependsOn(
    typeof(LabApplicationContractsModule),
    typeof(AbpAccountHttpApiModule),
    typeof(AbpIdentityHttpApiModule),
    typeof(AbpPermissionManagementHttpApiModule),
    typeof(AbpTenantManagementHttpApiModule),
    typeof(AbpFeatureManagementHttpApiModule),
    typeof(AbpSettingManagementHttpApiModule),
    typeof(MeasurementHttpApiModule)
	)]
public class LabHttpApiModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        ConfigureLocalization();
	 //	ConfigureAutoApiControllers();
	}

    private void ConfigureLocalization()
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<LabResource>()
                .AddBaseTypes(
                    typeof(AbpUiResource)
                );
        });
    }

	private void ConfigureAutoApiControllers()
	{
		//Configure<AbpAspNetCoreMvcOptions>(options =>
		//{
		//	options.ConventionalControllers.Create(typeof(BookModule).Assembly);
		//});
	}
}
