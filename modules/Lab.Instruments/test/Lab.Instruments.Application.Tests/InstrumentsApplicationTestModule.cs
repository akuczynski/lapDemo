using Volo.Abp.Modularity;

namespace Lab.Instruments;

[DependsOn(
    typeof(InstrumentsApplicationModule),
    typeof(InstrumentsDomainTestModule)
    )]
public class InstrumentsApplicationTestModule : AbpModule
{

}
