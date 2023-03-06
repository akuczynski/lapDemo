using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Lab.Instruments;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(InstrumentsHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class InstrumentsConsoleApiClientModule : AbpModule
{

}
