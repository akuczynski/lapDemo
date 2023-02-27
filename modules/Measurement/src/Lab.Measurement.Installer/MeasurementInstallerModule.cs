using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Lab.Measurement;

[DependsOn(
    typeof(AbpVirtualFileSystemModule)
    )]
public class MeasurementInstallerModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<MeasurementInstallerModule>();
        });
    }
}
