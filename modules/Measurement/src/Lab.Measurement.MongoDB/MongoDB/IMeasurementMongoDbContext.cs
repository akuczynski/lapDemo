using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Lab.Measurement.MongoDB;

[ConnectionStringName(MeasurementDbProperties.ConnectionStringName)]
public interface IMeasurementMongoDbContext : IAbpMongoDbContext
{
    /* Define mongo collections here. Example:
     * IMongoCollection<Question> Questions { get; }
     */
}
