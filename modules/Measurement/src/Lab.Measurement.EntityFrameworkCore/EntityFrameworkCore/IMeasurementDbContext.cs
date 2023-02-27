using Lab.Measurement.Entities;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Lab.Measurement.EntityFrameworkCore;

[ConnectionStringName(MeasurementDbProperties.ConnectionStringName)]
public interface IMeasurementDbContext : IEfCoreDbContext
{
	/* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */

	DbSet<Sample> Samples { get; set; }
}
