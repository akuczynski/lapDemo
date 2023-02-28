using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Lab.Measurement.Samples;

public interface ISampleAppService : IApplicationService
{
    Task<List<SampleDto>> GetListAsync();

    Task<SampleDto> CreateAsync(SampleDto sampleDto);

    Task DeleteAsync(Guid id); 

}
