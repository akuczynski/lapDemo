using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Lab.Measurement.Entities;
using Microsoft.AspNetCore.Authorization;
using Volo.Abp.Domain.Repositories;
using System.Linq;
using Lab.Measurement.Permissions;

namespace Lab.Measurement.Samples;

public class SampleAppService : MeasurementAppService, ISampleAppService
{
	private IRepository<Sample, Guid> _sampleRepository;

	public SampleAppService(IRepository<Sample, Guid> sampleRepository)
	{
		_sampleRepository = sampleRepository; 
	}

	public async Task<SampleDto> GetAsync()
	{
		var item = await _sampleRepository.GetAsync(x => x.Id != Guid.Empty);
		var result = ObjectMapper.Map<Sample, SampleDto>(item);

		return result;
	}

	[Authorize(MeasurementPermissions.SampleGet)]
	public async Task<SampleDto> GetAuthorizedAsync()
	{
		var item = await _sampleRepository.GetAsync(x => x.Id != Guid.Empty);
		var result = ObjectMapper.Map<Sample, SampleDto>(item);

		return result;
	}

}
