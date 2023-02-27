using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Lab.Measurement.EntityFrameworkCore;

public class MeasurementHttpApiHostMigrationsDbContext : AbpDbContext<MeasurementHttpApiHostMigrationsDbContext>
{
    public MeasurementHttpApiHostMigrationsDbContext(DbContextOptions<MeasurementHttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureMeasurement();
    }
}
