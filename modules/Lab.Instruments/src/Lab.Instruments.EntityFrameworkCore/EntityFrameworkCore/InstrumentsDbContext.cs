using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Lab.Instruments.EntityFrameworkCore;

[ConnectionStringName(InstrumentsDbProperties.ConnectionStringName)]
public class InstrumentsDbContext : AbpDbContext<InstrumentsDbContext>, IInstrumentsDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public InstrumentsDbContext(DbContextOptions<InstrumentsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureInstruments();
    }
}
