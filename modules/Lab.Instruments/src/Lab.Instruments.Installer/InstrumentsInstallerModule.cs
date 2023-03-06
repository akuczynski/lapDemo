using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Lab.Instruments;

[DependsOn(
    typeof(AbpVirtualFileSystemModule)
    )]
public class InstrumentsInstallerModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<InstrumentsInstallerModule>();
        });
    }
}
