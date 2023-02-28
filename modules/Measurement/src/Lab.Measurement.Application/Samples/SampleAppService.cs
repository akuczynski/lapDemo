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

    public Task<Guid> CreateAsync(SampleDto sampleDto)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task<SampleDto> GetAsync()
	{
        var item = await _sampleRepository.GetAsync(x => x.Measurement == "Measurement 1" && x.Number == 1);
		var result = ObjectMapper.Map<Sample, SampleDto>(item);

		return result;
	}

	[Authorize(MeasurementPermissions.Samples.Default)]
	public async Task<SampleDto> GetAuthorizedAsync()
	{
		var item = await _sampleRepository.GetAsync(x => x.Measurement == "Measurement 1" && x.Number == 1);
		var result = ObjectMapper.Map<Sample, SampleDto>(item);

		return result;
	}

    public Task<List<SampleDto>> GetListAsync()
    {
        throw new NotImplementedException();
    }
}
