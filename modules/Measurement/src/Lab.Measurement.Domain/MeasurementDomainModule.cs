using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Lab.Measurement;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(MeasurementDomainSharedModule)
)]
public class MeasurementDomainModule : AbpModule
{

}
