using Volo.Abp;
using Volo.Abp.MongoDB;

namespace Lab.Measurement.MongoDB;

public static class MeasurementMongoDbContextExtensions
{
    public static void ConfigureMeasurement(
        this IMongoModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));
    }
}
