using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Lab.Instruments.EntityFrameworkCore;

[ConnectionStringName(InstrumentsDbProperties.ConnectionStringName)]
public interface IInstrumentsDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
