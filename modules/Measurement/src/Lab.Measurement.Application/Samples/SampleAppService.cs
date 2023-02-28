using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Lab.Measurement.Entities;
using Microsoft.AspNetCore.Authorization;
using Volo.Abp.Domain.Repositories;
using System.Linq;
using Lab.Measurement.Permissions;
using Volo.Abp.ObjectMapping;
using static System.Net.Mime.MediaTypeNames;

namespace Lab.Measurement.Samples;

public class SampleAppService : MeasurementAppService, ISampleAppService
{
	private IRepository<Sample, Guid> _sampleRepository;

	public SampleAppService(IRepository<Sample, Guid> sampleRepository)
	{
		_sampleRepository = sampleRepository; 
	}

    [Authorize(MeasurementPermissions.Samples.Create)]
    public async Task<SampleDto> CreateAsync(SampleDto sampleDto)
    {
        var item = ObjectMapper.Map<SampleDto, Sample>(sampleDto);
      
        var savedItem = await _sampleRepository.InsertAsync(item);
        var result = ObjectMapper.Map<Sample, SampleDto>(savedItem);
        return result;
    }

    public async Task DeleteAsync(Guid id)
    {
        await _sampleRepository.DeleteAsync(id);
    } 

    [Authorize(MeasurementPermissions.Samples.Default)]
    public async Task<List<SampleDto>> GetListAsync()
    {
        var items = await _sampleRepository.GetListAsync();
        var orderedItems = items.OrderBy(x => x.Measurement).ThenBy(x => x.Number).ToList();

        var result = ObjectMapper.Map<List<Sample>, List<SampleDto>>(orderedItems);

        return result;
    }
}
