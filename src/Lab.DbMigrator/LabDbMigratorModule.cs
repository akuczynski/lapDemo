using Lab.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Lab.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(LabEntityFrameworkCoreModule),
    typeof(LabApplicationContractsModule)
    )]
public class LabDbMigratorModule : AbpModule
{

}
