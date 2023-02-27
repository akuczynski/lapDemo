﻿using Lab.Measurement.Entities;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Lab.Measurement.EntityFrameworkCore;

public static class MeasurementDbContextModelCreatingExtensions
{
    public static void ConfigureMeasurement(
        this ModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));

		builder.Entity<Sample>(b =>
		{
			//Configure table & schema name
			b.ToTable("Samples", MeasurementDbProperties.DbSchema);

			b.ConfigureByConvention();
		});


		/* Configure all entities here. Example:

        builder.Entity<Question>(b =>
        {
            //Configure table & schema name
            b.ToTable(MeasurementDbProperties.DbTablePrefix + "Questions", MeasurementDbProperties.DbSchema);

            b.ConfigureByConvention();

            //Properties
            b.Property(q => q.Title).IsRequired().HasMaxLength(QuestionConsts.MaxTitleLength);

            //Relations
            b.HasMany(question => question.Tags).WithOne().HasForeignKey(qt => qt.QuestionId);

            //Indexes
            b.HasIndex(q => q.CreationTime);
        });
        */
	}
}
