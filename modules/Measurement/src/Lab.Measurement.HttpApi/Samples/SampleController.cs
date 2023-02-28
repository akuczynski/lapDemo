using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp;

namespace Lab.Measurement.Samples;

[Area(MeasurementRemoteServiceConsts.ModuleName)]
[RemoteService(Name = MeasurementRemoteServiceConsts.RemoteServiceName)]
[Route("api/Measurement/sample")]
public class SampleController : MeasurementController, ISampleAppService
{
    private readonly ISampleAppService _sampleAppService;

    public SampleController(ISampleAppService sampleAppService)
    {
        _sampleAppService = sampleAppService;
    }

    public Task<Guid> CreateAsync(SampleDto sampleDto)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    [HttpGet]
    public async Task<SampleDto> GetAsync()
    {
        return await _sampleAppService.GetAsync();
    }

    [HttpGet]
    [Route("authorized")]
    [Authorize]
    public async Task<SampleDto> GetAuthorizedAsync()
    {
        return await _sampleAppService.GetAsync();
    }

    public Task<List<SampleDto>> GetListAsync()
    {
        throw new NotImplementedException();
    }
}
