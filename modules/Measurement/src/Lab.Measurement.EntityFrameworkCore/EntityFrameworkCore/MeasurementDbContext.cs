using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Lab.Measurement.Entities; 

namespace Lab.Measurement.EntityFrameworkCore;

[ConnectionStringName(MeasurementDbProperties.ConnectionStringName)]
public class MeasurementDbContext : AbpDbContext<MeasurementDbContext>, IMeasurementDbContext
{
	/* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

	public DbSet<Sample> Samples { get; set; }

	public MeasurementDbContext(DbContextOptions<MeasurementDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureMeasurement();
    }
}
