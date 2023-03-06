using Lab.Measurement;
using Volo.Abp.Account;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.ObjectExtending;
using Volo.Abp.PermissionManagement;
using Volo.Abp.SettingManagement;
using Volo.Abp.TenantManagement;
using Lab.Instruments;

namespace Lab;

[DependsOn(
    typeof(LabDomainSharedModule),
    typeof(AbpAccountApplicationContractsModule),
    typeof(AbpFeatureManagementApplicationContractsModule),
    typeof(AbpIdentityApplicationContractsModule),
    typeof(AbpPermissionManagementApplicationContractsModule),
    typeof(AbpSettingManagementApplicationContractsModule),
    typeof(AbpTenantManagementApplicationContractsModule),
    typeof(AbpObjectExtendingModule),
    typeof(MeasurementApplicationContractsModule)
)]
[DependsOn(typeof(InstrumentsApplicationContractsModule))]
    public class LabApplicationContractsModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        LabDtoExtensions.Configure();
    }
}
