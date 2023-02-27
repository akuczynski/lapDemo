using Lab.Measurement.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Lab.Measurement;

/* Domain tests are configured to use the EF Core provider.
 * You can switch to MongoDB, however your domain tests should be
 * database independent anyway.
 */
[DependsOn(
    typeof(MeasurementEntityFrameworkCoreTestModule)
    )]
public class MeasurementDomainTestModule : AbpModule
{

}
