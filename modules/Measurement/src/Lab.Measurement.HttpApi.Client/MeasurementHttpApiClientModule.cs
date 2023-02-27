using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Lab.Measurement;

[DependsOn(
    typeof(MeasurementApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class MeasurementHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(MeasurementApplicationContractsModule).Assembly,
            MeasurementRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<MeasurementHttpApiClientModule>();
        });

    }
}
