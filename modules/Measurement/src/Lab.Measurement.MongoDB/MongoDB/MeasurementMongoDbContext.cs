using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Lab.Measurement.MongoDB;

[ConnectionStringName(MeasurementDbProperties.ConnectionStringName)]
public class MeasurementMongoDbContext : AbpMongoDbContext, IMeasurementMongoDbContext
{
    /* Add mongo collections here. Example:
     * public IMongoCollection<Question> Questions => Collection<Question>();
     */

    protected override void CreateModel(IMongoModelBuilder modelBuilder)
    {
        base.CreateModel(modelBuilder);

        modelBuilder.ConfigureMeasurement();
    }
}
