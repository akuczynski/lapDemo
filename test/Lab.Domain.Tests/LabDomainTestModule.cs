using Lab.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Lab;

[DependsOn(
    typeof(LabEntityFrameworkCoreTestModule)
    )]
public class LabDomainTestModule : AbpModule
{

}
