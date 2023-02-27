using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Lab.Measurement.EntityFrameworkCore;

public class MeasurementHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<MeasurementHttpApiHostMigrationsDbContext>
{
    public MeasurementHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<MeasurementHttpApiHostMigrationsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Measurement"));

        return new MeasurementHttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
