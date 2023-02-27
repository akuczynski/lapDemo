using Lab.Measurement.Entities;
using System;
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

			var sample = new Sample
			{
				DataOfMeasurement = DateTime.Now,
				LaborantName = "Maria Curie"
			};

			await _sampleRepository.InsertAsync(sample);
		}
	}
}
