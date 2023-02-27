using Volo.Abp.Modularity;

namespace Lab.Measurement;

[DependsOn(
    typeof(MeasurementApplicationModule),
    typeof(MeasurementDomainTestModule)
    )]
public class MeasurementApplicationTestModule : AbpModule
{

}
