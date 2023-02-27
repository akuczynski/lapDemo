using Volo.Abp.Modularity;

namespace Lab;

[DependsOn(
    typeof(LabApplicationModule),
    typeof(LabDomainTestModule)
    )]
public class LabApplicationTestModule : AbpModule
{

}
