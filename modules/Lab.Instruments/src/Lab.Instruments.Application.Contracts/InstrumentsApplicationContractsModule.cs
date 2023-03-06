using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace Lab.Instruments;

[DependsOn(
    typeof(InstrumentsDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class InstrumentsApplicationContractsModule : AbpModule
{

}
