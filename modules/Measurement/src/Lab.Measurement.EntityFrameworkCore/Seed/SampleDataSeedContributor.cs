using Lab.Measurement.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Guids;
using Volo.Abp.MultiTenancy;

namespace Lab.Measurement.Seed
{
	public class SampleDataSeedContributor
	: IDataSeedContributor, ITransientDependency
	{
		private readonly IRepository<Sample, Guid> _sampleRepository;

		public SampleDataSeedContributor(
			IRepository<Sample, Guid> sampleRepository)
		{
			_sampleRepository = sampleRepository;
		}

		public async Task SeedAsync(DataSeedContext context)
		{
			if (await _sampleRepository.GetCountAsync() > 0)
			{
				return;
			}

			var sampleData = new List<Sample>();

            sampleData.Add(new Sample
			{
				Measurement = "Measurement 1",
                Number = 1,
                Value = 1, 
			});

            sampleData.Add(new Sample
            {
                Measurement = "Measurement 1",
                Number = 2,
                Value = 2,
            });

            sampleData.Add(new Sample
            {
                Measurement = "Measurement 1",
                Number = 3,
                Value = 2,
            });

            sampleData.Add(new Sample
            {
                Measurement = "Measurement 2",
                Number = 1,
                Value = 5,
            });

            sampleData.Add(new Sample
            {
                Measurement = "Measurement 2",
                Number = 2,
                Value = 5,
            });

            await _sampleRepository.InsertManyAsync(sampleData);
		}
	}
}
