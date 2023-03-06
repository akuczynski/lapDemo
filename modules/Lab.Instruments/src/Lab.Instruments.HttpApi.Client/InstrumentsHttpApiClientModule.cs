using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Lab.Instruments;

[DependsOn(
    typeof(InstrumentsApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class InstrumentsHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(InstrumentsApplicationContractsModule).Assembly,
            InstrumentsRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<InstrumentsHttpApiClientModule>();
        });

    }
}
