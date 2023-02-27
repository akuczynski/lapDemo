using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Lab.Measurement;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(MeasurementHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class MeasurementConsoleApiClientModule : AbpModule
{

}
