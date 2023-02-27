using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Lab.Measurement.EntityFrameworkCore;

[DependsOn(
    typeof(MeasurementDomainModule),
    typeof(AbpEntityFrameworkCoreModule)
)]
public class MeasurementEntityFrameworkCoreModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<MeasurementDbContext>(options =>
        {
			/* Add custom repositories here. Example:
			 * options.AddRepository<Question, EfCoreQuestionRepository>();
			 */
			options.AddDefaultRepositories(includeAllEntities: true);
		});
    }
}
