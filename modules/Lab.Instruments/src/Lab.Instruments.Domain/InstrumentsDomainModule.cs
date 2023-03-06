using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Lab.Instruments;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(InstrumentsDomainSharedModule)
)]
public class InstrumentsDomainModule : AbpModule
{

}
