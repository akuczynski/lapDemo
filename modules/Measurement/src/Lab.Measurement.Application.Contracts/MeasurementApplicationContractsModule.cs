using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace Lab.Measurement;

[DependsOn(
    typeof(MeasurementDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class MeasurementApplicationContractsModule : AbpModule
{

}
